using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CategoriesController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetCategories()
        {
            //throw new Exception("Exception");

            var categories = _service.CategoryService.GetAllCategories(trackChanges: false);

            return Ok(categories);
        }

        [HttpGet("{id:int}", Name = "categotyById")]
        public IActionResult GetCategory(int companyId)
        {
            var category = _service.CategoryService.GetCategory(companyId, trackChanges: false);

            return Ok(category);
        }
    }
}
