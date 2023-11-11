using Microsoft.AspNetCore.Mvc;
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
        public IActionResult CreateAddressForProvider(Guid providerId, [FromBody] ProviderAddressForCreationDto address)
        {
            if (address is null)
                return BadRequest("ProviderAddressForCreationDto object is null");

            var addressToReturn = _service.ProviderAddressService.CreateAddressForProvider(providerId, address, trackChanges: false);

            return CreatedAtRoute("GetAddressForProvider", new { providerId, id = addressToReturn.ProviderAddressID }, addressToReturn);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteAddressForProvider(Guid providerId, Guid id)
        {
            _service.ProviderAddressService.DeleteAddressForProvider(providerId, id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public IActionResult GetAddressesForProvider(Guid providerId) 
        {
            var addresses = _service.ProviderAddressService.GetAddresses(providerId, trackChanges: false);

            return Ok(addresses);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "GetAddressForProvider")]
        public IActionResult GetAddressForProvider(Guid providerId, Guid id)
        {
            var address = _service.ProviderAddressService.GetAddressForProvider(providerId, id, trackChanges: false);

            return Ok(address);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public IActionResult UpdateAddressForProvider(Guid providerId, Guid id, [FromBody] ProviderAddressForUpdateDto addressForUpdate)
        {
            if (addressForUpdate is null)
                return BadRequest("ProviderAddressForUpdateDto object is null");

            _service.ProviderAddressService.UpdateAddressForProvider(providerId, id, addressForUpdate, proTrackChanges: false, adrTrackChanges: true);

            return NoContent();
        }
    }
}
