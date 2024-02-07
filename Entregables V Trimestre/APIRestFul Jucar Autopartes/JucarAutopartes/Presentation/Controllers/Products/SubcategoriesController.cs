using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
using Presentation.ModelBinders;
using Service.Contracts;
using Shared.DataTransferObjects.Products;

namespace Presentation.Controllers.Products
{
    //[Route("api/subcategories")]
    [Route("api/categories/{categoryId}/subcategories")]
    [ApiController]
    public class SubcategoriesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public SubcategoriesController(IServiceManager service) =>
            _service = service;

        /* Crear una subcategoria */
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateSubcategoryForCategory(Guid categoryId, [FromBody] SubcategoryForCreationDto subcategory)
        {
            var subcategoryToReturn = await _service.SubcategoryService.CreateSubcategoryForCategoryAsync(categoryId, subcategory, trackChanges: false);

            return CreatedAtRoute("GetSubcategoryByCategory", new { categoryId, id = subcategoryToReturn.SubcategoryId }, subcategoryToReturn);
        }

        /* Obtener todas las Subcategorias en general*/
        [HttpGet("/api/subcategories")]
        public async Task<IActionResult> GetSubcategories()
        {
            var subcategories = await _service.SubcategoryService.GetAllSubcategoriesAsync(trackChanges: false);

            return Ok(subcategories);
        }

        /* Obtener una Subcategoria especifica */
        [HttpGet("/api/subcategories/{id:guid}", Name = "SubcategoryById")]
        public async Task<IActionResult> GetSubcategoryById(Guid id)
        {
            var subcategory = await _service.SubcategoryService.GetSubcategoryByIdAsync(id, trackChanges: false);

            return Ok(subcategory);
        }

        /* Obtener todas las Subcategorias de una Categoria */
        [HttpGet]
        public async Task<IActionResult> GetSubcategoriesForCategory(Guid categoryId)
        {
            var subcategories = await _service.SubcategoryService.GetSubcategoriesAsync(categoryId, trackChanges: false);

            return Ok(subcategories);
        }

        /* Obtener una Subcategoria especifica de una Categoria */
        [HttpGet("{id:guid}", Name = "GetSubcategoryByCategory")]
        public async Task<IActionResult> GetSubcategoryByCategory(Guid categoryId, Guid id)
        {
            var subcategory = await _service.SubcategoryService.GetSubcategoryByCategoryAsync(categoryId, id, trackChanges: false);

            return Ok(subcategory);
        }

        /* Obtener una colección de subcategorías */
        [HttpGet("collection/({ids})", Name = "SubcategoryCollection")]
        public async Task<IActionResult> GetSubcategoryCollection([ModelBinder(BinderType = typeof(ArraryModelBinder))] IEnumerable<Guid> ids)
        {
            var subcategories = await _service.SubcategoryService.GetByIdsAsync(ids, trackChanges: false);

            return Ok(subcategories);
        }

        /* Actualizar una Subcategoría */
        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateSubcategoryForCategory(Guid categoryId, Guid id, [FromBody] SubcategoryForUpdateDto subcategory)
        {
            await _service.SubcategoryService.UpdateSubcategoryForCategoryAsync(categoryId, id, subcategory, catTrackChanges: false, subTrackChanges: true);

            return NoContent();
        }

        /* Eliminar una Subcategoria */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteSubcategoryForCategory(Guid categoryId, Guid id)
        {
            await _service.SubcategoryService.DeleteSubcategoryForCategoryAsync(categoryId, id, trackChanges: false);

            return NoContent();
        }
    }
}
