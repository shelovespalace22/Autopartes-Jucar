using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects.Providers.Provider;
using Shared.DataTransferObjects.Sales.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Sales
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IServiceManager _service;

        public OrdersController(IServiceManager service) =>
            _service = service;

        /* Crear */
        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderForCreationDto order)
        {
            if (order is null)
                return BadRequest("OrderForCreationDto object is null");

            var createdOrder = _service.OrderService.CreateOrder(order);

            return CreatedAtRoute("OrderById", new { id = createdOrder.OrderID }, createdOrder);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteOrder(Guid id)
        {
            _service.OrderService.DeleteOrder(id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = _service.OrderService.GetAllOrders(trackChanges: false);

            return Ok(orders);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "OrderById")]
        public IActionResult GetOrder(Guid id)
        {
            var order = _service.OrderService.GetOrder(id, trackChanges: false);

            return Ok(order);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        public IActionResult UpdateOrder(Guid id, [FromBody] OrderForUpdateDto order)
        {
            if (order is null)
                return BadRequest("OrderForUpdateDto object is null");

            _service.OrderService.UpdateOrder(id, order, trackChanges: true);

            return NoContent();
        }
    }
}
