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
    [Route("api/rawMaterials/{rawMaterialId}/stocks")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IServiceManager _service;

        public StocksController(IServiceManager service) => 
            _service = service;


        /* Crear */
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateStockForRawMaterial(Guid rawMaterialId, [FromBody] StockForCreationDto stock)
        {
            var stockToReturn = await _service.StockService.CreateStockForRawMaterialAsync(rawMaterialId, stock, trackChanges: false);

            return CreatedAtRoute("GetStockByRawMaterial", new { rawMaterialId, id = stockToReturn.StockID }, stockToReturn);
        }

        /* Eliminar */
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteStockForRawMaterial(Guid rawMaterialId, Guid id)
        {
            await _service.StockService.DeleteStockForRawMaterialAsync(rawMaterialId, id, trackChanges: false);

            return NoContent();
        }

        /* Único Registro */
        [HttpGet("{id:guid}", Name = "GetStockByRawMaterial")]
        public async Task<IActionResult> GetStockByRawMaterial(Guid rawMaterialId, Guid id)
        {
            var stock = await _service.StockService.GetStockForRawMaterialAsync(rawMaterialId, id, trackChanges: false);

            return Ok(stock);
        }

        /* Listar */
        [HttpGet]
        public async Task<IActionResult> GetStocksForRawMaterial(Guid rawMaterialId)
        {
            var stocks = await _service.StockService.GetStocksAsync(rawMaterialId, trackChanges: false);

            return Ok(stocks);
        }

        /* Actualizar */
        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateStopckForRawMaterial(Guid rawMaterialId, Guid id, [FromBody] StockForUpdateDto stock)
        {
            await _service.StockService.UpdateStockForRawMaterialAsync(rawMaterialId, id, stock, rawTrackChanges: false, stcTrackChanges: true);

            return NoContent();
        }
    }
}
 