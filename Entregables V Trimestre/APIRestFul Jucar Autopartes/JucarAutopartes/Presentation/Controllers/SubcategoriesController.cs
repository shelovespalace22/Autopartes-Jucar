using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers
{
    [Route("api/subcategories")]
    [ApiController]
    public class SubcategoriesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public SubcategoriesController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetSubcategories()
        {
            var subcategories = _service.SubcategoryService.GetAllSubcategories(trackChanges: false);

            return Ok(subcategories);
        }
    }
}
