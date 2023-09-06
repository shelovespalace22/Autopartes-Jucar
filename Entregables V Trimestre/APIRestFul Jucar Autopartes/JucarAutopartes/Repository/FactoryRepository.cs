using Contracts;
using Entities.Models.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FactoryRepository : RepositoryBase<Factory>, IFactoryRepository
    {
        public FactoryRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
          
        }
    }
}
