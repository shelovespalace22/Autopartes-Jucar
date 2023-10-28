using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Service.Contracts;
using Presentation.ModelBinders;
using Shared.DataTransferObjects.Products;
using Entities.Exceptions;

namespace Presentation.Controllers.Products
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CategoriesController(IServiceManager service) =>
            _service = service;

        /* Crear una categoria */
        [HttpPost]
        public IActionResult CreateCategory([FromBody] CategoryForCreationDto category)
        {
            if (category is null)
                return BadRequest("CategoryForCreationDto object is null");

            var createdCategory = _service.CategoryService.CreateCategory(category);

            return CreatedAtRoute("CategoryById", new { id = createdCategory.CategoryId }, createdCategory);
        }

        /* Crear una colección de categorias */
        [HttpPost("collection")]
        public IActionResult CreateCategoryCollection([FromBody] IEnumerable<CategoryForCreationDto> categoryCollection)
        {
            var result = _service.CategoryService.CreateCategoryCollection(categoryCollection);

            return CreatedAtRoute("CategoryCollection", new { result.ids }, result.categories);
        }

        /* Obtener todas las categorias */
        [HttpGet]
        public IActionResult GetCategories()
        {
            //throw new Exception("Exception");

            var categories = _service.CategoryService.GetAllCategories(trackChanges: false);

            return Ok(categories);
        }

        /* Obtener una categoria especifica */
        [HttpGet("{id:guid}", Name = "CategoryById")]
        public IActionResult GetCategory(Guid id)
        {
            var category = _service.CategoryService.GetCategory(id, trackChanges: false);

            return Ok(category);
        }


        /* Obtener una colección de categorias */
        [HttpGet("collection/({ids})", Name = "CategoryCollection")]
        public IActionResult GetCategoryCollection([ModelBinder(BinderType = typeof(ArraryModelBinder))] IEnumerable<Guid> ids)
        {
            var categories = _service.CategoryService.GetByIds(ids, trackChanges: false);

            return Ok(categories);
        }

        /* Actualizar una categoria */
        [HttpPut("{id:guid}")]
        public IActionResult UpdateCategory(Guid id, [FromBody] CategoryForUpdateDto category)
        {
            if (category is null)
                return BadRequest("CategoryForUpdateDto object is null");

            _service.CategoryService.UpdateCategory(id, category, trackChanges: true);

            return NoContent();
        }

        /* Eliminar una categoria y sus subcategorias */
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteCategory(Guid id)
        {
            _service.CategoryService.DeleteCategory(id, trackChanges: false);

            return NoContent();
        }
    }
}
