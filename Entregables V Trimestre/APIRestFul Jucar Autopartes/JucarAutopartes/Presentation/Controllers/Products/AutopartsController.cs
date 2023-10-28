//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Presentation.ModelBinders;
//using Service.Contracts;
//using Shared.DataTransferObjects.Products;

//namespace Presentation.Controllers.Products
//{
//    [Route("api/subcategories/{subcategoryId}/autoparts")]
//    [ApiController]
//    public class AutopartsController : ControllerBase
//    {
//        private readonly IServiceManager _service;

//        public AutopartsController(IServiceManager service) =>
//            _service = service;

//        /* Crear una autoparte */
//        [HttpPost]
//        public IActionResult CreateAutopartForSubcategory(Guid subcategoryId, [FromBody] AutopartForCreationDto autopart)
//        {
//            if (autopart is null)
//                return BadRequest("AutopartForCreationDto object is null");

//            var autopartToReturn = _service.AutopartService.CreateAutopartForSubcategory(subcategoryId, autopart, trackChanges: false);

//            return CreatedAtRoute("GetAutopartBySubcategory", new { subcategoryId, id = autopartToReturn.AutopartID }, autopartToReturn);
//        }

//        /* Obteniendo todas las Autopartes en general */
//        [HttpGet("/api/autoparts")]
//        public IActionResult GetAutoparts()
//        {
//            var autoparts = _service.AutopartService.GetAllAutoparts(trackChanges: false);

//            return Ok(autoparts);
//        }

//        /* Obteniendo Autoparte por su Id */
//        [HttpGet("/api/autoparts/{id:guid}")]
//        public IActionResult GetAutopart(Guid id)
//        {
//            var autopart = _service.AutopartService.GetAutopartById(id, trackChanges: false);

//            return Ok(autopart);
//        }

//        /* Obtener todas las Autopartes de una Subcategoria */

//        public IActionResult GetAutopartsForCategory(Guid subcategoryId)
//        {
//            var autoparts = _service.AutopartService.GetAutoparts(subcategoryId, trackChanges: false);

//            return Ok(autoparts);
//        }

//        /* Obtener una Autoparte especifica de una Subcategoria */
//        [HttpGet("{id:guid}", Name = "GetAutopartBySubcategory")]
//        public IActionResult GetAutopartBySubcategory(Guid subcategoryId, Guid id)
//        {
//            var autopart = _service.AutopartService.GetAutopartBySubcategory(subcategoryId, id, trackChanges: false);

//            return Ok(autopart);
//        }

//        /* Obtener una colección de autopartes */

//        [HttpGet("collection/({ids})", Name = "AutopartCollection")]
//        public IActionResult GetAutopartCollection([ModelBinder(BinderType = typeof(ArraryModelBinder))] IEnumerable<Guid> ids)
//        {
//            var autoparts = _service.AutopartService.GetByIds(ids, trackChanges: false);

//            return Ok(autoparts);
//        }

//        /* Actualizar una Autoparte */
//        [HttpPut("{id:guid}")]
//        public IActionResult UpdateAutopartForSubcategory(Guid subcategoryId, Guid id, [FromBody] AutopartForUpdateDto autopart)
//        {
//            if (autopart is null)
//                return BadRequest("AutopartForUpdateDto object is null.");

//            _service.AutopartService.UpdateAutopartForSubcategory(subcategoryId, id, autopart, subcTrackChanges: false, trackChanges: true);

//            return NoContent();
//        }

//        /* Eliminar una Autoparte */
//        [HttpDelete("{id:guid}")]
//        public IActionResult DeleteAutopartForSubcategory(Guid subcategoryId, Guid id)
//        {
//            _service.AutopartService.DeleteAutopartForSubcategory(subcategoryId, id, trackChanges: false);

//            return NoContent();
//        }
//    }
//}
