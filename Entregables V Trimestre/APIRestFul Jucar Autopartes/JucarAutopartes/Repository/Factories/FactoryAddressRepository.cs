using Contracts.Factory;
using Entities.Models.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Factory
{
    public class FactoryAddressRepository : RepositoryBase<FactoryAddress>, IFactoryAddressRepository
    {
        public FactoryAddressRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }
    }
}
