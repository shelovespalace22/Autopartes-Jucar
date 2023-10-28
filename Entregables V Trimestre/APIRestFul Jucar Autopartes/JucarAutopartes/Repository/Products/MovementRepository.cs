using Contracts.Products;
using Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Products
{
    public class MovementRepository : RepositoryBase<Movement>, IMovementRepository
    {
        public MovementRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }
    }
}
