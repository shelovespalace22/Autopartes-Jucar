using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Ubications
{
    [Route("api/municipalities/{municipalityId}/neighborhoods")]
    [ApiController]
    public class NeighborhoodsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public NeighborhoodsController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public async Task<IActionResult> GetNeighborhoods(Guid municipalityId)
        {
            var neighborhoods = await _service.NeighborhoodService.GetNeighborhoodsAsync(municipalityId, trackChanges: false);

            return Ok(neighborhoods);
        }
        
    }
}
