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
using Presentation.ActionFilters;
using Microsoft.AspNetCore.Authorization;

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

        /// <summary>
        /// Create una nueva categoría.
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Una recién creada categoría</returns>
        /// <response code="201">Retorna el elemento recién creado</response> 
        /// <response code="400">Si el elemento está vacío</response>
        /// <response code="422">Si el modelo es inválido</response>
        [HttpPost(Name = "CrearCategoría")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(422)]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryForCreationDto category)
        {
            //if (category is null)
            //    return BadRequest("CategoryForCreationDto object is null");

            //if (!ModelState.IsValid)
            //    return UnprocessableEntity(ModelState);

            var createdCategory = await _service.CategoryService.CreateCategoryAsync(category);

            return CreatedAtRoute("CategoryById", new { id = createdCategory.CategoryId }, createdCategory);
        }

        /* Crear una colección de categorias */
        [HttpPost("collection")]
        public async Task<IActionResult> CreateCategoryCollection([FromBody] IEnumerable<CategoryForCreationDto> categoryCollection)
        {
            var result = await _service.CategoryService.CreateCategoryCollectionAsync(categoryCollection);

            return CreatedAtRoute("CategoryCollection", new { result.ids }, result.categories);
        }

        /* Obtener todas las categorias */

        /// <summary>
        /// Obten la lista de todas las categorías.
        /// </summary>
        /// <returns>La lista de categorías disponibles.</returns>
        [HttpGet]
        //[Authorize(Roles = "Manager")]
        public async Task<IActionResult> GetCategories()
        { 
            var categories = await _service.CategoryService.GetAllCategoriesAsync(trackChanges: false);

            return Ok(categories);
        }

        /* Obtener una categoria especifica */
        [HttpGet("{id:guid}", Name = "CategoryById")]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            var category = await _service.CategoryService.GetCategoryAsync(id, trackChanges: false);

            return Ok(category);
        }

        /* Obtener una colección de categorias */
        [HttpGet("collection/({ids})", Name = "CategoryCollection")]
        public async Task<IActionResult> GetCategoryCollection([ModelBinder(BinderType = typeof(ArraryModelBinder))] IEnumerable<Guid> ids)
        {
            var categories = await _service.CategoryService.GetByIdsAsync(ids, trackChanges: false);

            return Ok(categories);
        }

        /* Actualizar una categoria */
        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateCategory(Guid id, [FromBody] CategoryForUpdateDto category)
        {
            //if (category is null)
            //    return BadRequest("CategoryForUpdateDto object is null");

            //if (!ModelState.IsValid)
            //    return UnprocessableEntity(ModelState);

            await _service.CategoryService.UpdateCategoryAsync(id, category, trackChanges: true);

            return NoContent();
        }

        /* Eliminar una categoria y sus subcategorias */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            await _service.CategoryService.DeleteCategoryAsync(id, trackChanges: false);

            return NoContent();
        }
    }
}
