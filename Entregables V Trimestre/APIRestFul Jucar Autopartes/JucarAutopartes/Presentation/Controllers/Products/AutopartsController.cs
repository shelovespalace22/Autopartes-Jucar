using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Presentation.ModelBinders;
using Service.Contracts;
using Shared.DataTransferObjects.Products;

namespace Presentation.Controllers.Products
{
    [Route("api/subcategories/{subcategoryId}/autoparts")]
    [ApiController]
    public class AutopartsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AutopartsController(IServiceManager service) =>
            _service = service;

        /* Crear una autoparte */
        [HttpPost]
        public async Task<IActionResult> CreateAutopartForSubcategory(Guid subcategoryId, [FromBody] AutopartForCreationDto autopart)
        {
            if (autopart is null)
                return BadRequest("AutopartForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var autopartToReturn = await _service.AutopartService.CreateAutopartForSubcategoryAsync(subcategoryId, autopart, trackChanges: false);

            return CreatedAtRoute("GetAutopartBySubcategory", new { subcategoryId, id = autopartToReturn.AutopartID }, autopartToReturn);
        }

        /* Obteniendo todas las Autopartes en general */
        [HttpGet("/api/autoparts")]
        public async Task<IActionResult> GetAutoparts()
        {
            var autoparts = await _service.AutopartService.GetAllAutopartsAsync(trackChanges: false);

            return Ok(autoparts);
        }

        /* Obteniendo Autoparte por su Id */
        [HttpGet("/api/autoparts/{id:guid}")]
        public async Task<IActionResult> GetAutopart(Guid id)
        {
            var autopart = await _service.AutopartService.GetAutopartByIdAsync(id, trackChanges: false);

            return Ok(autopart);
        }

        /* Obtener todas las Autopartes de una Subcategoria */
        public async Task<IActionResult> GetAutopartsForCategory(Guid subcategoryId)
        {
            var autoparts = await _service.AutopartService.GetAutopartsAsync(subcategoryId, trackChanges: false);

            return Ok(autoparts);
        }

        /* Obtener una Autoparte especifica de una Subcategoria */
        [HttpGet("{id:guid}", Name = "GetAutopartBySubcategory")]
        public async Task<IActionResult> GetAutopartBySubcategory(Guid subcategoryId, Guid id)
        {
            var autopart = await _service.AutopartService.GetAutopartBySubcategoryAsync(subcategoryId, id, trackChanges: false);

            return Ok(autopart);
        }

        /* Obtener una colección de autopartes */
        [HttpGet("collection/({ids})", Name = "AutopartCollection")]
        public async Task<IActionResult> GetAutopartCollection([ModelBinder(BinderType = typeof(ArraryModelBinder))] IEnumerable<Guid> ids)
        {
            var autoparts = await _service.AutopartService.GetByIdsAsync(ids, trackChanges: false);

            return Ok(autoparts);
        }

        /* Actualizar una Autoparte */
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateAutopartForSubcategory(Guid subcategoryId, Guid id, [FromBody] AutopartForUpdateDto autopart)
        {
            if (autopart is null)
                return BadRequest("AutopartForUpdateDto object is null.");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _service.AutopartService.UpdateAutopartForSubcategoryAsync(subcategoryId, id, autopart, subcTrackChanges: false, trackChanges: true);

            return NoContent();
        }

        /* Eliminar una Autoparte */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAutopartForSubcategory(Guid subcategoryId, Guid id)
        {
            await _service.AutopartService.DeleteAutopartForSubcategoryAsync(subcategoryId, id, trackChanges: false);

            return NoContent();
        }
    }
}
