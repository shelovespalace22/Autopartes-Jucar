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
        public async Task<IActionResult> GetDetails(Guid orderId)
        {
            var details = await _service.OrderDetailService.GetDetailsForOrderAsync(orderId, trackChanges: false);

            return Ok(details);
        }
    }
}
