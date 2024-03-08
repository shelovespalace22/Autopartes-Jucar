using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers.Ubications
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public DepartmentsController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
            var departments = await _service.DepartmentService.GetDepartmentsAsync(trackChanges: false);

            return Ok(departments);
        }
    }
}
