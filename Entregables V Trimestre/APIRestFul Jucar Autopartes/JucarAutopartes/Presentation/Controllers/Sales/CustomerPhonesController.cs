using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
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
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreatePhoneForCustomer(Guid customerId, [FromBody] CustomerPhoneForCreationDto phone)
        {
            var phoneToReturn = await _service.CustomerPhoneService.CreatePhoneAsync(customerId, phone, trackChanges: false);

            return CreatedAtRoute("GetPhoneForCustomer", new { customerId, id = phoneToReturn.CustomerPhoneID }, phoneToReturn);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeletePhoneForCustomer(Guid customerId, Guid id)
        {
            await _service.CustomerPhoneService.DeletePhoneAsync(customerId, id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public async Task<IActionResult> GetPhonesForCustomer(Guid customerId)
        {
            var phones = await _service.CustomerPhoneService.GetPhonesAsync(customerId, trackChanges: false);

            return Ok(phones);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "GetPhoneForCustomer")]
        public async Task<IActionResult> GetPhoneForCustomer(Guid customerId, Guid id)
        {
            var phone = await _service.CustomerPhoneService.GetPhoneAsync(customerId, id, trackChanges: false);

            return Ok(phone);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdatePhoneForCustomer(Guid customerId, Guid id, [FromBody] CustomerPhoneForUpdateDto phoneForUpdate)
        {
            await _service.CustomerPhoneService.UpdatePhoneAsync(customerId, id, phoneForUpdate, cusTrackChanges: false, phoTrackChanges: true);

            return NoContent();
        }
    }
}
