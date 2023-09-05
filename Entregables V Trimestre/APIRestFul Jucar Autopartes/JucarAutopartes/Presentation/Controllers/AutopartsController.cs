using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers
{
    [Route("api/autoparts")]
    [ApiController]
    public class AutopartsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AutopartsController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetAutoparts()
        {
            var autoparts = _service.AutopartService.GetAllAutoparts(trackChanges: false);

            return Ok(autoparts);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetAutopart(Guid id)
        {
            var autopart = _service.AutopartService.GetAutopart(id, trackChanges: false);

            return Ok(autopart);
        }
    }
}
