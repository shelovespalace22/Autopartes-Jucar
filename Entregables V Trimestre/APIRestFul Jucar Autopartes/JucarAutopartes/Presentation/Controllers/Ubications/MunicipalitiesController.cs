using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Ubications
{
    [Route("api/departments/{departmentId}/municipalities")]
    [ApiController]
    public class MunicipalitiesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public MunicipalitiesController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public async Task<IActionResult> GetMunicipalitiesForDepartment(Guid departmentId)
        {
            var municipalities = await _service.MunicipaliityService.GetMunicipalitiesAsync(departmentId, trackChanges: false);

            return Ok(municipalities);
        }
        
    }
}
