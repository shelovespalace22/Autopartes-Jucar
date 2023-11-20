using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects.Sales.CustomerAddress;
using Shared.DataTransferObjects.Sales.CustomerPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Sales
{
    [Route("api/customers/{customerId}/phones")]
    [ApiController]
    public class CustomerPhonesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CustomerPhonesController(IServiceManager service) =>
            _service = service;

        /* Crear */
        [HttpPost]
        public IActionResult CreatePhoneForCustomer(Guid customerId, [FromBody] CustomerPhoneForCreationDto phone)
        {
            if (phone is null)
                return BadRequest("CustomerPhoneForCreationDto object is null.");

            var phoneToReturn = _service.CustomerPhoneService.CreatePhone(customerId, phone, trackChanges: false);

            return CreatedAtRoute("GetPhoneForCustomer", new { customerId, id = phoneToReturn.CustomerPhoneID }, phoneToReturn);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public IActionResult DeletePhoneForCustomer(Guid customerId, Guid id)
        {
            _service.CustomerPhoneService.DeletePhone(customerId, id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public IActionResult GetPhonesForCustomer(Guid customerId)
        {
            var phones = _service.CustomerPhoneService.GetPhones(customerId, trackChanges: false);

            return Ok(phones);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "GetPhoneForCustomer")]
        public IActionResult GetPhoneForCustomer(Guid customerId, Guid id)
        {
            var phone = _service.CustomerPhoneService.GetPhone(customerId, id, trackChanges: false);

            return Ok(phone);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public IActionResult UpdatePhoneForCustomer(Guid customerId, Guid id, [FromBody] CustomerPhoneForUpdateDto phoneForUpdate)
        {
            if (phoneForUpdate is null)
                return BadRequest("CustomerPhoneForUpdateDto object is null.");

            _service.CustomerPhoneService.UpdatePhone(customerId, id, phoneForUpdate, cusTrackChanges: false, phoTrackChanges: true);

            return NoContent();
        }
    }
}
