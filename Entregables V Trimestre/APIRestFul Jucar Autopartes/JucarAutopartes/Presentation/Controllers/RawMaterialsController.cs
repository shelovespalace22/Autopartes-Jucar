using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/rawMaterials")]
    [ApiController]
    public class RawMaterialsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public RawMaterialsController(IServiceManager service) =>
            _service = service;


        /* Crear un RawMaterial */
        [HttpPost]
        public IActionResult CreateRawMaterial([FromBody] RawMaterialForCreationDto rawMaterial)
        {
            if (rawMaterial is null)
                return BadRequest("RawMaterialForCreationDto object is null.");

            var createdRawMaterial = _service.RawMaterialService.CreateRawMaterial(rawMaterial);

            return CreatedAtRoute("GetRawMaterial", new { id = createdRawMaterial.rawMaterialId }, createdRawMaterial);
        }
    }
}
