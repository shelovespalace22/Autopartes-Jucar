using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Products
{
    public interface IStockService
    {
        /* Crear*/
        Task<StockDto> CreateStockForRawMaterialAsync(Guid rawMaterialId, StockForCreationDto stockForCreation, bool trackChanges);

        /* Listar */
        Task<IEnumerable<StockDto>> GetStocksAsync(Guid rawMaterialId, bool trackChanges);

        /* Único Registro */
        Task<StockDto> GetStockForRawMaterialAsync(Guid rawMaterialId, Guid id, bool trackChanges);

        /* Actualizar */
        Task UpdateStockForRawMaterialAsync(Guid rawMaterialId, Guid id, StockForUpdateDto stockForUpdate, bool rawTrackChanges, bool stcTrackChanges);

        /* Eliminar */
        Task DeleteStockForRawMaterialAsync(Guid rawMaterialId, Guid id, bool trackChanges);
    }
}
