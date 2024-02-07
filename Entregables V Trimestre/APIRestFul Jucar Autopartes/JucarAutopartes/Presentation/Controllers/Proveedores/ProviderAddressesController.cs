using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Presentation.ActionFilters;
using Service.Contracts;
using Shared.DataTransferObjects.Providers.ProviderAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Proveedores
{
    [Route("api/providers/{providerId}/addresses")]
    [ApiController]
    public class ProviderAddressesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ProviderAddressesController(IServiceManager service) =>
             _service = service;

        /* Crear */
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateAddressForProvider(Guid providerId, [FromBody] ProviderAddressForCreationDto address)
        {
            var addressToReturn = await _service.ProviderAddressService.CreateAddressForProviderAsync(providerId, address, trackChanges: false);

            return CreatedAtRoute("GetAddressForProvider", new { providerId, id = addressToReturn.ProviderAddressID }, addressToReturn);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAddressForProvider(Guid providerId, Guid id)
        {
            await _service.ProviderAddressService.DeleteAddressForProviderAsync(providerId, id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public async Task<IActionResult> GetAddressesForProvider(Guid providerId) 
        {
            var addresses = await _service.ProviderAddressService.GetAddressesAsync(providerId, trackChanges: false);

            return Ok(addresses);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "GetAddressForProvider")]
        public async Task<IActionResult> GetAddressForProvider(Guid providerId, Guid id)
        { 
            var address = await _service.ProviderAddressService.GetAddressForProviderAsync(providerId, id, trackChanges: false);

            return Ok(address);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateAddressForProvider(Guid providerId, Guid id, [FromBody] ProviderAddressForUpdateDto addressForUpdate)
        {
            await _service.ProviderAddressService.UpdateAddressForProviderAsync(providerId, id, addressForUpdate, proTrackChanges: false, adrTrackChanges: true);

            return NoContent();
        }
    }
}
