using Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Products
{
    public interface IStockRepository
    {
        /* Crear */     
        void CreateStockForRawMaterial(Guid rawMaterialId, Stock stock);

        /* Listar */
        Task<IEnumerable<Stock>> GetStocksAsync(Guid rawMaterialId, bool trackChanges);

        /* Único Registro */
        Task<Stock> GetStockByRawMaterialAsync(Guid rawMaterialId, Guid id, bool trackChanges);

        /* Eliminar*/
        void DeleteStock(Stock stock);


        

        void UpdateStockQuantity(Stock stock);
    }
}
