using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects.Providers.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Proveedores
{
    [Route("api/providers")]
    [ApiController]
    public class ProvidersController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ProvidersController(IServiceManager service) => 
            _service = service;


        /* Crear */
        [HttpPost]
        public IActionResult CreateProvider([FromBody] ProviderForCreationDto provider)
        {
            if (provider is null)
                return BadRequest("ProviderForCreationDto object is null");

            var createdProvider = _service.ProviderService.CreateProvider(provider);

            return CreatedAtRoute("ProviderById", new { id = createdProvider.ProviderID }, createdProvider);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteProvider(Guid id)
        {
            _service.ProviderService.DeleteProvider(id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public IActionResult GetProviders() 
        {
            var providers = _service.ProviderService.GetAllProviders(trackChanges: false);

            return Ok(providers);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "ProviderById")]
        public IActionResult GetProvider(Guid id)
        {
            var provider = _service.ProviderService.GetProvider(id, trackChanges: false);

            return Ok(provider);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public IActionResult UpdateProvider(Guid id, [FromBody] ProviderForUpdateDto provider)
        {
            if (provider is null)
                return BadRequest("ProviderForUpdateDto object is null");

            _service.ProviderService.UpdateProvider(id, provider, trackChanges: true);

            return NoContent();
        }
    }
}
