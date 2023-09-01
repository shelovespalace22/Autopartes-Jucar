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
            try
            {
                var autoparts = _service.AutopartService.GetAllAutoparts(trackChanges: false);

                return Ok(autoparts);
            }
            catch
            {

                return StatusCode(500, "Internal server error");
            }
        }
    }
}
