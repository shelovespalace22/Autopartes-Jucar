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
    [Route("")]
    [ApiController]
    public class AutopartMaterialsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AutopartMaterialsController(IServiceManager service) =>
            _service = service;


        /* Crear un material */


    }
}
