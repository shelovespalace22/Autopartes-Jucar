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
        public IActionResult CreateCustomer([FromBody] CustomerForCreationDto customer)
        {
            if (customer is null)
                return BadRequest("CustomerForCreationDto object is null.");

            var createdCustomer = _service.CustomerService.CreateCustomer(customer);

            return CreatedAtRoute("CustomerById", new { id = createdCustomer.CustomerID }, createdCustomer);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteCustomer(Guid id)
        {
            _service.CustomerService.DeleteCustomer(id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = _service.CustomerService.GetAllCustomers(trackChanges: false);

            return Ok(customers);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "CustomerById")]
        public IActionResult GetCustomer(Guid id)
        {
            var customer = _service.CustomerService.GetCustomer(id, trackChanges: false);

            return Ok(customer);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public IActionResult UpdateCustomer(Guid id, [FromBody] CustomerForUpdateDto customer)
        {
            if (customer is null)
                return BadRequest("CustomerForUpdateDto object is null.");

            _service.CustomerService.UpdateCustomer(id, customer, trackChanges: true);

            return NoContent();
        }
    }
}
