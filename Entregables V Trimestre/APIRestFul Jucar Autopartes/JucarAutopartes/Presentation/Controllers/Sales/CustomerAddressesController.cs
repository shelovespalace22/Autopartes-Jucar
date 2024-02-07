using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
using Service.Contracts;
using Shared.DataTransferObjects.Sales.CustomerAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Sales
{
    [Route("api/customers/{customerId}/addresses")]
    [ApiController]
    public class CustomerAddressesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CustomerAddressesController(IServiceManager service) =>
            _service = service;

        /* Crear */
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateAddressForCustomer(Guid customerId, [FromBody] CustomerAddressForCreationDto address)
        {
            var addressToReturn = await _service.CustomerAddressService.CreateAddressAsync(customerId, address, trackChanges: false);

            return CreatedAtRoute("GetAddressForCustomer", new { customerId, id = addressToReturn.CustomerAddressID }, addressToReturn);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAddressForCustomer(Guid customerId, Guid id)
        {
            await _service.CustomerAddressService.DeleteAddressAsync(customerId, id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public async Task<IActionResult> GetAddressesForCustomer(Guid customerId)
        {
            var addresses = await _service.CustomerAddressService.GetAddressesAsync(customerId, trackChanges: false);

            return Ok(addresses);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "GetAddressForCustomer")]
        public async Task<IActionResult> GetAddressForCustomer(Guid customerId, Guid id)
        {
            var address = await _service.CustomerAddressService.GetAddressAsync(customerId, id, trackChanges: false);

            return Ok(address);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateAddressForCustomer(Guid customerId, Guid id, [FromBody] CustomerAddressForUpdateDto addressForUpdate)
        {
            await _service.CustomerAddressService.UpdateAddressAsync(customerId, id, addressForUpdate, cusTrackChanges: false, adrTrackChanges: true);

            return NoContent();
        }
    }
}
