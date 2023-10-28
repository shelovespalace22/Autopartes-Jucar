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
        public IActionResult GetRawMaterials()
        {
            var rawMaterials = _service.RawMaterialService.GetAllRawMaterials(trackChanges: false);

            return Ok(rawMaterials);
        }

        /* Obtener una Materia Prima */
        
        [HttpGet("{id:guid}", Name = "RawMaterialById")]
        public IActionResult GetRawMaterial(Guid id)
        {
            var rawMaterial = _service.RawMaterialService.GetRawMaterial(id, trackChanges: false);

            return Ok(rawMaterial);
        }

        /* Crear una Materia Prima */

        [HttpPost]
        public IActionResult CreateRawMaterial([FromBody] RawMaterialForCreationDto rawMaterial)
        {
            if (rawMaterial is null)
                return BadRequest("RawMaterialForCreationDto object is null");

            var createdRawMaterial = _service.RawMaterialService.CreateRawMaterial(rawMaterial);

            return CreatedAtRoute("RawMaterialById", new { id = createdRawMaterial.RawMaterialId }, createdRawMaterial);
        }

        /* Obtener una colección de Materias Primas */
        [HttpGet("collection/({ids})", Name = "RawMaterialCollection")]
        public IActionResult GetRawMaterialCollection([ModelBinder(BinderType = typeof(ArraryModelBinder))] IEnumerable<Guid> ids)
        {
            var rawMaterials = _service.RawMaterialService.GetByIds(ids, trackChanges: false);

            return Ok(rawMaterials);
        }

        /* Crear una colección de Materias Primas */
        [HttpPost("collection")]
        public IActionResult CreateRawMaterialCollection([FromBody] IEnumerable<RawMaterialForCreationDto> rawMaterialCollection)
        {
            var result = _service.RawMaterialService.CreateRawMaterialCollection(rawMaterialCollection);

            return CreatedAtRoute("RawMaterialCollection", new { result.ids }, result.rawMaterials);
        }

        /* Eliminar una Materia Prima */
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteCompany(Guid id)
        {
            _service.RawMaterialService.DeleteRawMaterial(id, trackChanges: false);

            return NoContent();
        }

        /* Actualizar una Materia Prima */
        [HttpPut("{id:guid}")]
        public IActionResult UpdateRawMaterial(Guid id, [FromBody] RawMaterialForUpdateDto rawMaterial)
        {
            if (rawMaterial is null)
                return BadRequest("RawMaterialForUpdateDto object is null.");

            _service.RawMaterialService.UpdateRawMaterial(id, rawMaterial, trackChanges: true);

            return NoContent();
        }

    }


}
