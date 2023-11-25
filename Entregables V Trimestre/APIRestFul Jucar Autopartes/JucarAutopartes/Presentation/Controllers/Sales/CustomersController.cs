using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects.Sales.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Sales
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CustomersController(IServiceManager service) =>
            _service = service;

        /* Crear */
        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerForCreationDto customer)
        {
            if (customer is null)
                return BadRequest("CustomerForCreationDto object is null.");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var createdCustomer = await _service.CustomerService.CreateCustomerAsync(customer);

            return CreatedAtRoute("CustomerById", new { id = createdCustomer.CustomerID }, createdCustomer);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            await _service.CustomerService.DeleteCustomerAsync(id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _service.CustomerService.GetAllCustomersAsync(trackChanges: false);

            return Ok(customers);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "CustomerById")]
        public async Task<IActionResult> GetCustomer(Guid id)
        {
            var customer = await _service.CustomerService.GetCustomerAsync(id, trackChanges: false);

            return Ok(customer);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateCustomer(Guid id, [FromBody] CustomerForUpdateDto customer)
        {
            if (customer is null)
                return BadRequest("CustomerForUpdateDto object is null.");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _service.CustomerService.UpdateCustomerAsync(id, customer, trackChanges: true);

            return NoContent();
        }
    }
}
