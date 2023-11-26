using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
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
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateLossForAutopart(Guid autopartId, [FromBody] LossForCreationDto loss)
        {
            var lossToReturn = await _service.LossService.CreateLossForAutopartAsync(autopartId, loss, trackChanges: false);

            return CreatedAtRoute("GetLossByAutopart", new { autopartId, id = lossToReturn.LossID }, lossToReturn);
        }


        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteLossForAutopart(Guid autopartId, Guid id)
        {
            await _service.LossService.DeleteLossForAutopartAsync(autopartId, id, trackChanges: false);

            return NoContent();
        }


        /* Único Registro */
        [HttpGet("{id:guid}", Name = "GetLossByAutopart")]
        public async Task<IActionResult> GetLossByAutopart(Guid autopartId, Guid id)
        {
            var loss = await _service.LossService.GetLossByAutopartAsync(autopartId, id, trackChanges: false);

            return Ok(loss);
        }


        /* Listar */
        [HttpGet]
        public async Task<IActionResult> GetLossesForAutopart(Guid autopartId)
        {
            var loss = await _service.LossService.GetLossesAsync(autopartId, trackChanges: false);

            return Ok(loss);
        }


        /* Actualizar */
        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateLossForAutopart(Guid autopartId, Guid id, [FromBody] LossForUpdateDto loss)
        {
            await _service.LossService.UpdateLossForAutopartAsync(autopartId, id, loss, autTrackChanges: false, losTrackChanges: true);

            return NoContent();
        }
    }
}
