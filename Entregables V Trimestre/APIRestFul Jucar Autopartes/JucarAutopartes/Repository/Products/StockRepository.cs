using Contracts.Products;
using Entities.Models.Products;
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
        public IEnumerable<Stock> GetStocks(Guid rawMaterialId, bool trackChanges) =>
            FindByCondition(s => s.RawMaterialId.Equals(rawMaterialId), trackChanges)
            .OrderBy(s => s.QuantityAvailable)
            .ToList();




        /* Único Registro */
        public Stock GetStockByRawMaterial(Guid rawMaterialId, Guid id, bool trackChanges) =>
            FindByCondition(s => s.RawMaterialId.Equals(rawMaterialId) && s.StockID.Equals(id), trackChanges)
            .SingleOrDefault();




        /* Eliminar*/
        public void DeleteStock(Stock stock) => Delete(stock);
    }
}
