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
    [Route("api/autoparts/{autopartId}/materials")]
    [ApiController]
    public class AutopartMaterialsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AutopartMaterialsController(IServiceManager service) =>
            _service = service;


        /* Crear un material */


        /* Obtener todos los materiales */

        [HttpGet("/api/materials")]
        public IActionResult GetAllMaterials()
        {
            var materials = _service.AutopartMaterialService.GetAllMaterials(trackChanges: false);

            return Ok(materials);
        }

        /* Obtener todos los Materiales de una Autoparte */

        public IActionResult GetMaterialsForAutopart (Guid autopartId)
        {
            var materials = _service.AutopartMaterialService.GetMaterials(autopartId, trackChanges: false);

            return Ok(materials);
        }

    }
}
