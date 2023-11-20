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
        StockDto CreateStockForRawMaterial(Guid rawMaterialId, StockForCreationDto stockForCreation, bool trackChanges);

        /* Listar */
        IEnumerable<StockDto> GetStocks(Guid rawMaterialId, bool trackChanges);

        /* Único Registro */
        StockDto GetStockForRawMaterial(Guid rawMaterialId, Guid id, bool trackChanges);

        /* Actualizar */
        void UpdateStockForRawMaterial(Guid rawMaterialId, Guid id, StockForUpdateDto stockForUpdate, bool rawTrackChanges, bool stcTrackChanges);

        /* Eliminar */
        void DeleteStockForRawMaterial(Guid rawMaterialId, Guid id, bool trackChanges);
    }
}
