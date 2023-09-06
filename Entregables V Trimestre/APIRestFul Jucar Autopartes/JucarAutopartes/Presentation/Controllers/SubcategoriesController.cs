using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Presentation.Controllers
{
    //[Route("api/subcategories")]
    [Route("api/categories/{categoryId}/subcategories")]
    [ApiController]
    public class SubcategoriesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public SubcategoriesController(IServiceManager service) =>
            _service = service;

        /* Obtener todas las Subcategorias en general*/
        [HttpGet("/api/subcategories")]
        public IActionResult GetSubcategories()
        {
            var subcategories = _service.SubcategoryService.GetAllSubcategories(trackChanges: false);

            return Ok(subcategories);
        }

        /* Obtener una Subcategoria por su Id */
        [HttpGet("/api/subcategories/{id:guid}")]
        public IActionResult GetSubcategoryById(Guid id)
        {
            var subcategory = _service.SubcategoryService.GetSubcategoryById(id, trackChanges: false);

            return Ok(subcategory);
        }

        /* Obtener todas las Subcategorias de una Categoria */

        public IActionResult GetSubcategoriesForCategory(Guid categoryId) 
        {
            var subcategories = _service.SubcategoryService.GetSubcategories(categoryId, trackChanges: false);

            return Ok(subcategories);
        }

        /* Obtener una Subcategoria especifica de una Categoria */
        [HttpGet("{id:guid}", Name = "GetSubcategoryByCategory")]
        public IActionResult GetSubcategoryByCategory(Guid categoryId, Guid id)
        {
            var subcategory = _service.SubcategoryService.GetSubcategoryByCategory(categoryId, id, trackChanges: false);

            return Ok(subcategory);
        }

        /* Crear una subcategoria */
        [HttpPost]
        public IActionResult CreateSubcategoryForCategory(Guid categoryId, [FromBody] SubcategoryForCreationDto subcategory)
        {
            if (subcategory is null)
                return BadRequest("SubcategoryForCreationDto object is null");

            var subcategoryToReturn = _service.SubcategoryService.CreateSubcategoryForCategory(categoryId, subcategory, trackChanges: false);

            return CreatedAtRoute("GetSubcategoryByCategory", new { categoryId, id = subcategoryToReturn.SubcategoryId }, subcategoryToReturn);
        }
    }
}
