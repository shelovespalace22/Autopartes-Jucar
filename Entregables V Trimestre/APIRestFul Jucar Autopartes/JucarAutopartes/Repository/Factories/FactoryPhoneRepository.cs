using Contracts.Factory;
using Entities.Models.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Factory
{
    public class FactoryPhoneRepository : RepositoryBase<FactoryPhone>, IFactoryPhoneRepository
    {
        public FactoryPhoneRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }
    }
}
