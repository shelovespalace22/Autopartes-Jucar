using Microsoft.AspNetCore.Mvc;
using Presentation.ModelBinders;
using Service.Contracts;
using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Products
{
    [Route("api/rawMaterials")]
    [ApiController]
    public class RawMaterialsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public RawMaterialsController(IServiceManager service) =>
            _service = service;


        /* Obtener todas las Materias Primas */
        [HttpGet]
        public async Task<IActionResult> GetRawMaterials()
        {
            var rawMaterials = await _service.RawMaterialService.GetAllRawMaterialsAsync(trackChanges: false);

            return Ok(rawMaterials);
        }

        /* Obtener una Materia Prima */
        [HttpGet("{id:guid}", Name = "RawMaterialById")]
        public async Task<IActionResult> GetRawMaterial(Guid id)
        {
            var rawMaterial = await _service.RawMaterialService.GetRawMaterialAsync(id, trackChanges: false);

            return Ok(rawMaterial);
        }

        /* Crear una Materia Prima */
        [HttpPost]
        public async Task<IActionResult> CreateRawMaterial([FromBody] RawMaterialForCreationDto rawMaterial)
        {
            if (rawMaterial is null)
                return BadRequest("RawMaterialForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var createdRawMaterial = await _service.RawMaterialService.CreateRawMaterialAsync(rawMaterial);

            return CreatedAtRoute("RawMaterialById", new { id = createdRawMaterial.RawMaterialId }, createdRawMaterial);
        }

        /* Obtener una colección de Materias Primas */
        [HttpGet("collection/({ids})", Name = "RawMaterialCollection")]
        public async Task<IActionResult> GetRawMaterialCollection([ModelBinder(BinderType = typeof(ArraryModelBinder))] IEnumerable<Guid> ids)
        {
            var rawMaterials = await _service.RawMaterialService.GetByIdsAsync(ids, trackChanges: false);

            return Ok(rawMaterials);
        }

        /* Crear una colección de Materias Primas */
        [HttpPost("collection")]
        public async Task<IActionResult> CreateRawMaterialCollection([FromBody] IEnumerable<RawMaterialForCreationDto> rawMaterialCollection)
        {
            var result = await _service.RawMaterialService.CreateRawMaterialCollectionAsync(rawMaterialCollection);

            return CreatedAtRoute("RawMaterialCollection", new { result.ids }, result.rawMaterials);
        }

        /* Eliminar una Materia Prima */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteCompany(Guid id)
        {
            await _service.RawMaterialService.DeleteRawMaterialAsync(id, trackChanges: false);

            return NoContent();
        }

        /* Actualizar una Materia Prima */
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateRawMaterial(Guid id, [FromBody] RawMaterialForUpdateDto rawMaterial)
        {
            if (rawMaterial is null)
                return BadRequest("RawMaterialForUpdateDto object is null.");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _service.RawMaterialService.UpdateRawMaterialAsync(id, rawMaterial, trackChanges: true);

            return NoContent();
        }
    }
}
