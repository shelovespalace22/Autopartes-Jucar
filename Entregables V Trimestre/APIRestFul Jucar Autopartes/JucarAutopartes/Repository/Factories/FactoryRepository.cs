using Contracts.Factory;
using Entities.Models.Factories;
using Entities.Models.Products;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Factory
{

    public class FactoryRepository : RepositoryBase<Factory>, IFactoryRepository
    {
        public FactoryRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public IEnumerable<Factory> GetAllFactories(bool trakChanges) =>
          FindAll(trakChanges)
          .OrderBy(c => c.BusinessName)
          .ToList();




    }
}
