using Microsoft.AspNetCore.Mvc;
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
        public IActionResult CreateAddressForCustomer(Guid customerId, [FromBody] CustomerAddressForCreationDto address)
        {
            if (address is null)
                return BadRequest("CustomerAddressForCreationDto object is null.");

            var addressToReturn = _service.CustomerAddressService.CreateAddress(customerId, address, trackChanges: false);

            return CreatedAtRoute("GetAddressForCustomer", new { customerId, id = addressToReturn.CustomerAddressID }, addressToReturn);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteAddressForCustomer(Guid customerId, Guid id)
        {
            _service.CustomerAddressService.DeleteAddress(customerId, id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public IActionResult GetAddressesForCustomer(Guid customerId)
        {
            var addresses = _service.CustomerAddressService.GetAddresses(customerId, trackChanges: false);

            return Ok(addresses);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "GetAddressForCustomer")]
        public IActionResult GetAddressForCustomer(Guid customerId, Guid id)
        {
            var address = _service.CustomerAddressService.GetAddress(customerId, id, trackChanges: false);

            return Ok(address);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public IActionResult UpdateAddressForCustomer(Guid customerId, Guid id, [FromBody] CustomerAddressForUpdateDto addressForUpdate)
        {
            if (addressForUpdate is null)
                return BadRequest("CustomerAddressForUpdateDto object is null.");

            _service.CustomerAddressService.UpdateAddress(customerId, id, addressForUpdate, cusTrackChanges: false, adrTrackChanges: true);

            return NoContent();
        }
    }
}
