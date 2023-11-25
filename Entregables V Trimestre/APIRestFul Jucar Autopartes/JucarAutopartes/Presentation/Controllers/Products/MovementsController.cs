using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Products
{
    [Route("api/rawMaterials/{rawMaterialId}/movements")]
    [ApiController]
    public class MovementsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public MovementsController(IServiceManager service) =>
            _service = service;


        /* Crear */

        [HttpPost]
        public IActionResult CreateMovementForRawmaterial(Guid rawMaterialId, [FromBody] MovementForCreationDto movement)
        {
            if (movement is null)
                return BadRequest("MovementForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var movementToReturn = _service.MovementService.CreateMovementForRawmaterial(rawMaterialId, movement, trackChanges: false);

            return CreatedAtRoute("GetMovementByRawmaterial", new { rawMaterialId, id = movementToReturn.MovementID }, movementToReturn);
        }

        /* Eliminar */

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteMovementForRawmaterial(Guid rawMaterialId, Guid id)
        {
            _service.MovementService.DeleteMovementForRawmaterial(rawMaterialId, id, trackChanges: false);

            return NoContent();
        }

        /* Único Registro */

        [HttpGet("{id:guid}", Name = "GetMovementByRawmaterial")]
        public IActionResult GetMovementByRawmaterial(Guid rawMaterialId, Guid id)
        {
            var movement = _service.MovementService.GetMovementForRawmaterial(rawMaterialId, id, trackChanges: false);

            return Ok(movement);
        }

        /* Listar */

        [HttpGet]
        public IActionResult GetMovementsForRawmaterial(Guid rawMaterialId)
        {
            var movements = _service.MovementService.GetMovements(rawMaterialId, trackChanges: false);

            return Ok(movements);
        }

        /* Actualizar */

        [HttpPut("{id:guid}")]
        public IActionResult UpdateMovementForRawmaterial(Guid rawMaterialId, Guid id, [FromBody] MovementForUpdateDto movement)
        {
            if (movement is null)
                return BadRequest("MovementForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            _service.MovementService.UpdateMovementForRawmaterial(rawMaterialId, id, movement, rawTrackChanges: false, movTrackChanges: true);

            return NoContent();
        }
    }



}
