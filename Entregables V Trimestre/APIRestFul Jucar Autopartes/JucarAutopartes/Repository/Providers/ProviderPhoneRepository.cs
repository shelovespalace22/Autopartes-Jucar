using Contracts.Providers;
using Entities.Models.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Providers
{
    public class ProviderPhoneRepository : RepositoryBase<ProviderPhone>, IProviderPhoneRepository
    {
        public ProviderPhoneRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }
    }
}
