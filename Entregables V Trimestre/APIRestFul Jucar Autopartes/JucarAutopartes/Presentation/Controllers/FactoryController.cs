using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/factories")]
    [ApiController]
    public class FactoryController : ControllerBase
    {
        private readonly IServiceManager _service;

        public FactoryController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetFactories() 
        {
            try
            {
                var factories = _service.FactoryService.GetAllFactories(trackChanges: false);
                return Ok(factories);   
            }
            catch 
            {
                return StatusCode(500, "internal server error");
            }
        }
    }
}
