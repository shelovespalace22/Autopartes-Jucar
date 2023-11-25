using Contracts.Products;
using Entities.Models.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Products
{
    public class StockRepository : RepositoryBase<Stock>, IStockRepository
    {
        public StockRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        /* Crear */
        public void CreateStockForRawMaterial(Guid rawMaterialId, Stock stock)
        {
            stock.RawMaterialId = rawMaterialId;

            Create(stock);
        }




        /* Listar */
        public async Task<IEnumerable<Stock>> GetStocksAsync(Guid rawMaterialId, bool trackChanges) =>
            await FindByCondition(s => s.RawMaterialId.Equals(rawMaterialId), trackChanges)
            .OrderBy(s => s.QuantityAvailable)
            .ToListAsync();




        /* Único Registro */
        public async Task<Stock> GetStockByRawMaterialAsync(Guid rawMaterialId, Guid id, bool trackChanges) =>
            await FindByCondition(s => s.RawMaterialId.Equals(rawMaterialId) && s.StockID.Equals(id), trackChanges)
            .SingleOrDefaultAsync();




        /* Eliminar*/
        public void DeleteStock(Stock stock) => Delete(stock);




        /* Actualizar Cantidad Disponible */
        public void UpdateStockQuantity(Stock stock)
        {
            Update(stock);
        }
    }
}
