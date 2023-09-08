using Contracts.Products;
using Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Products
{
    public class PriceHistoryRepository : RepositoryBase<PriceHistory>, IPriceHistoryRepository
    {
        public PriceHistoryRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }
    }
}
