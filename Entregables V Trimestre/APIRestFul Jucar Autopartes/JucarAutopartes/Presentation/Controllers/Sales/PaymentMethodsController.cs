using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects.Sales.PaymentMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Sales
{
    [Route("api/paymentMethods")]
    [ApiController]
    public class PaymentMethodsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PaymentMethodsController(IServiceManager service) =>
            _service = service;

        /* Crear */
        [HttpPost]
        public IActionResult CreatePaymentMethod([FromBody] PaymentMethodForCreationDto paymentMethod)
        {
            if (paymentMethod is null)
                return BadRequest("PaymentMethodForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var createdPaymentMethod = _service.PaymentMethodService.CreatePaymentMethod(paymentMethod);

            return CreatedAtRoute("PaymentMethodById", new { id = createdPaymentMethod.PaymentMethodID }, createdPaymentMethod);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public IActionResult DeletePaymentMethod(Guid id)
        {
            _service.PaymentMethodService.DeletePaymentMethod(id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public IActionResult GetPaymentMethods()
        {
            var paymentMethods = _service.PaymentMethodService.GetAllPaymentMethods(trackChanges: false);

            return Ok(paymentMethods);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "PaymentMethodById")]
        public IActionResult GetPaymentMethod(Guid id)
        {
            var paymentMethod = _service.PaymentMethodService.GetPaymentMethod(id, trackChanges: false);

            return Ok(paymentMethod);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public IActionResult UpdatePaymentMethod(Guid id, [FromBody] PaymentMethodForUpdateDto paymentMethodForUpdate)
        {
            if (paymentMethodForUpdate is null)
                return BadRequest("PaymentMethodForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            _service.PaymentMethodService.UpdatePaymentMethod(id, paymentMethodForUpdate, trackChanges: true);

            return NoContent();
        }
    }
}
