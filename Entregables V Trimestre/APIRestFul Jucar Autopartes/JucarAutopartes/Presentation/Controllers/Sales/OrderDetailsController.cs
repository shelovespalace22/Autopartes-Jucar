using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Sales
{
    [Route("api/orders/{orderId}/details")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public OrderDetailsController(IServiceManager service) =>
            _service = service;

        /* Listar */
        [HttpGet]
        public IActionResult GetDetails(Guid orderId)
        {
            var details = _service.OrderDetailService.GetDetailsForOrder(orderId, trackChanges: false);

            return Ok(details);
        }
    }
}
