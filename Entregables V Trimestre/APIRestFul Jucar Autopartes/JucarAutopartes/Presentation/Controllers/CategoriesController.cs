using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Service.Contracts;
using Shared.DataTransferObjects;
using Presentation.ModelBinders;

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

        [HttpGet("{id:guid}", Name = "CategoryById")]
        public IActionResult GetCategory(Guid id)
        {
            var category = _service.CategoryService.GetCategory(id, trackChanges: false);

            return Ok(category);
        }

        [HttpPost]
        public IActionResult CreateCategory([FromBody] CategoryForCreationDto category)
        {
            if (category is null)
                return BadRequest("CategoryForCreationDto object is null");

            var createdCategory = _service.CategoryService.CreateCategory(category);

            return CreatedAtRoute("CategoryById", new { id = createdCategory.CategoryId}, createdCategory);
        }

        [HttpGet("collection/({ids})", Name = "CategoryCollection")]
        public IActionResult GetCategoryCollection([ModelBinder(BinderType = typeof(ArraryModelBinder))] IEnumerable<Guid> ids)
        {
            var categories = _service.CategoryService.GetByIds(ids, trackChanges: false);

            return Ok(categories);
        }

        [HttpPost("collection")]
        public IActionResult CreateCategoryCollection([FromBody] IEnumerable<CategoryForCreationDto> categoryCollection)
        {
            var result = _service.CategoryService.CreateCategoryCollection(categoryCollection);

            return CreatedAtRoute("CategoryCollection", new { result.ids }, result.categories);
        }
    }
}
