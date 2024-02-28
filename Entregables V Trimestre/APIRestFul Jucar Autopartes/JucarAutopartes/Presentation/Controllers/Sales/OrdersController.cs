using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
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
    [Route("api/customers/{customerId}/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IServiceManager _service;

        public OrdersController(IServiceManager service) =>
            _service = service;

        /* Crear */
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateOrder(Guid customerId, [FromBody] OrderForCreationDto order)
        {
            var createdOrder = await _service.OrderService.CreateOrderAsync(customerId, order, trackChanges: false);

            return CreatedAtRoute("OrderById", new { customerId, id = createdOrder.OrderID }, createdOrder);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteOrder(Guid customerId, Guid id)
        {
            await _service.OrderService.DeleteOrderAsync(customerId, id, trackChanges: false);

            return NoContent();
        }

        /* Listar */
        [HttpGet]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetOrders(Guid customerId)
        {
            var orders = await _service.OrderService.GetAllOrdersAsync(customerId, trackChanges: false);

            return Ok(orders);
        }

        /* Un registro */
        [HttpGet("{id:guid}", Name = "OrderById")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetOrder(Guid customerId, Guid id)
        {
            var order = await _service.OrderService.GetOrderAsync(customerId, id, trackChanges: false);

            return Ok(order);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UpdateOrder(Guid customerId, Guid id, [FromBody] OrderForUpdateDto order)
        {
            await _service.OrderService.UpdateOrderAsync(customerId, id, order, cusTrackChanges: false, ordTrackChanges: true);

            return NoContent();
        }
    }
}
