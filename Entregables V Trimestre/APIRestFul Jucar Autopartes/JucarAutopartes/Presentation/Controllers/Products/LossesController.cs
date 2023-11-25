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
    [Route("api/autoparts/{autopartId}/losses")]
    [ApiController]
    public class LossesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public LossesController(IServiceManager service) => 
            _service = service;


        /* Crear */

        [HttpPost]
        public IActionResult CreateLossForAutopart(Guid autopartId, [FromBody] LossForCreationDto loss)
        {
            if (loss is null)
                return BadRequest("LossForCreationDto object is null");


            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var lossToReturn = _service.LossService.CreateLossForAutopart(autopartId, loss, trackChanges: false);

            return CreatedAtRoute("GetLossByAutopart", new { autopartId, id = lossToReturn.LossID }, lossToReturn);
        }


        /* Eliminar */

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteLossForAutopart(Guid autopartId, Guid id)
        {
            _service.LossService.DeleteLossForAutopart(autopartId, id, trackChanges: false);

            return NoContent();
        }


        /* Único Registro */

        [HttpGet("{id:guid}", Name = "GetLossByAutopart")]
        public IActionResult GetLossByAutopart(Guid autopartId, Guid id)
        {
            var loss = _service.LossService.GetLossByAutopart(autopartId, id, trackChanges: false);

            return Ok(loss);
        }


        /* Listar */

        [HttpGet]
        public IActionResult GetLossesForAutopart(Guid autopartId)
        {
            var loss = _service.LossService.GetLosses(autopartId, trackChanges: false);

            return Ok(loss);
        }


        /* Actualizar */

        [HttpPut("{id:guid}")]
        public IActionResult UpdateLossForAutopart(Guid autopartId, Guid id, [FromBody] LossForUpdateDto loss)
        {
            if (loss is null)
                return BadRequest("LossForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            _service.LossService.UpdateLossForAutopart(autopartId, id, loss, autTrackChanges: false, losTrackChanges: true);

            return NoContent();
        }
    }
}
