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
    [Route("api/subcategories/{subcategoryId}/autoparts")]
    [ApiController]
    public class AutopartsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AutopartsController(IServiceManager service) =>
            _service = service;

        /* Obteniendo todas las Autopartes en general */
        [HttpGet("/api/autoparts")]
        public IActionResult GetAutoparts()
        {
            var autoparts = _service.AutopartService.GetAllAutoparts(trackChanges: false);

            return Ok(autoparts);
        }

        /* Obteniendo Autoparte por su Id */
        [HttpGet("/api/autoparts/{id:guid}")]
        public IActionResult GetAutopart(Guid id)
        {
            var autopart = _service.AutopartService.GetAutopartById(id, trackChanges: false);

            return Ok(autopart);
        }

        /* Obtener todas las Autopartes de una Subcategoria */

        public IActionResult GetAutopartsForCategory(Guid subcategoryId)
        {
            var autoparts = _service.AutopartService.GetAutoparts(subcategoryId, trackChanges: false);

            return Ok(autoparts);
        }

        /* Obtener una Autoparte especifica de una Subcategoria */
        [HttpGet("{id:guid}", Name = "GetAutopartBySubcategory")]
        public IActionResult GetAutopartBySubcategory(Guid subcategoryId, Guid id)
        {
            var autopart = _service.AutopartService.GetAutopartBySubcategory(subcategoryId, id, trackChanges: false);

            return Ok(autopart);
        }

        /* Crear una autoparte */
        [HttpPost]
        public IActionResult CreateAutopartForSubcategory(Guid subcategoryId, [FromBody] AutopartForCreationDto autopart)
        {
            if (autopart is null)
                return BadRequest("AutopartForCreationDto object is null");

            var autopartToReturn = _service.AutopartService.CreateAutopartForSubcategory(subcategoryId, autopart, trackChanges: false);

            return CreatedAtRoute("GetAutopartBySubcategory", new { subcategoryId, id = autopartToReturn.AutopartID }, autopartToReturn);
        }
    }
}
