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
    [Route("api/rawMaterials/{rawMaterialId}/stocks")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IServiceManager _service;

        public StocksController(IServiceManager service) => 
            _service = service;


        /* Crear */

        [HttpPost]
        public IActionResult CreateStockForRawMaterial(Guid rawMaterialId, [FromBody] StockForCreationDto stock)
        {
            if (stock is null)
                return BadRequest("StockForCreationDto object is null");

            var stockToReturn = _service.StockService.CreateStockForRawMaterial(rawMaterialId, stock, trackChanges: false);

            return CreatedAtRoute("GetStockByRawMaterial", new { rawMaterialId, id = stockToReturn.StockID }, stockToReturn);
        }

        /* Eliminar */

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteStockForRawMaterial(Guid rawMaterialId, Guid id)
        {
            _service.StockService.DeleteStockForRawMaterial(rawMaterialId, id, trackChanges: false);

            return NoContent();
        }

        /* Único Registro */

        [HttpGet("{id:guid}", Name = "GetStockByRawMaterial")]
        public IActionResult GetStockByRawMaterial(Guid rawMaterialId, Guid id)
        {
            var stock = _service.StockService.GetStockForRawMaterial(rawMaterialId, id, trackChanges: false);

            return Ok(stock);
        }

        /* Listar */

        [HttpGet]
        public IActionResult GetStocksForRawMaterial(Guid rawMaterialId)
        {
            var stocks = _service.StockService.GetStocks(rawMaterialId, trackChanges: false);

            return Ok(stocks);
        }

        /* Actualizar */

        [HttpPut("{id:guid}")]
        public IActionResult UpdateStopckForRawMaterial(Guid rawMaterialId, Guid id, [FromBody] StockForUpdateDto stock)
        {
            if (stock is null)
                return BadRequest("StockForUpdateDto object is null");

            _service.StockService.UpdateStockForRawMaterial(rawMaterialId, id, stock, rawTrackChanges: false, stcTrackChanges: true);

            return NoContent();
        }
    }
}
