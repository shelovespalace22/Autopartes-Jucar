using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects.Providers.ProviderPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Proveedores
{
    [Route("api/providers/{providerId}/phones")]
    [ApiController]
    public class ProviderPhonesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ProviderPhonesController(IServiceManager service) =>
            _service = service;

        /* Crear */
        [HttpPost]
        public async Task<IActionResult> CreatePhoneForProvider(Guid providerId, [FromBody] ProviderPhoneForCreationDto phone)
        {
            if (phone is null)
                return BadRequest("ProviderPhoneForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var phoneToReturn = await _service.ProviderPhoneService.CreatePhoneForProviderAsync(providerId, phone, trackChanges: false);

            return CreatedAtRoute("GetPhoneForProvider", new { providerId, id = phoneToReturn.ProviderPhoneID }, phoneToReturn);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeletePhoneForProvider(Guid providerId, Guid id)
        {
            await _service.ProviderPhoneService.DeletePhoneForProviderAsync(providerId, id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public async Task<IActionResult> GetPhonesForProvider(Guid providerId)
        { 
            var phones = await _service.ProviderPhoneService.GetPhonesAsync(providerId, trackChanges: false);

            return Ok(phones);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "GetPhoneForProvider")]
        public async Task<IActionResult> GetPhoneForProvider(Guid providerId, Guid id)
        {
            var phone = await _service.ProviderPhoneService.GetPhoneForProviderAsync(providerId, id, trackChanges: false);

            return Ok(phone);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdatePhoneForProvider(Guid providerId, Guid id, [FromBody] ProviderPhoneForUpdateDto phoneForUpdate)
        {
            if (phoneForUpdate is null)
                return BadRequest("ProviderPhoneForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _service.ProviderPhoneService.UpdatePhoneForProviderAsync(providerId, id, phoneForUpdate, proTrackChanges: false, phoTrackChanges: true);

            return NoContent();
        }
    }
}
