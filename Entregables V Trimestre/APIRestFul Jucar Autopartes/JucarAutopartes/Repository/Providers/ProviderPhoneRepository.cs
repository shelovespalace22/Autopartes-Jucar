using Contracts.Providers;
using Entities.Models.Providers;
using Microsoft.EntityFrameworkCore;
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

        /* Crear */
        public void CreatePhoneForProvider(Guid providerId, ProviderPhone providerPhone)
        {
            providerPhone.ProviderId = providerId;

            Create(providerPhone);
        }


        /* Eliminar */
        public void DeleteProviderPhone(ProviderPhone providerPhone) => Delete(providerPhone);


        /* Un registro */
        public async Task<ProviderPhone> GetPhoneByProviderAsync(Guid providerId, Guid id, bool trackChanges) =>
            await FindByCondition(p => p.ProviderId.Equals(providerId) && p.ProviderPhoneID.Equals(id), trackChanges)
            .SingleOrDefaultAsync();


        /* Listar */
        public async Task<IEnumerable<ProviderPhone>> GetPhonesForProviderAsync(Guid providerId, bool trackChanges) =>
            await FindByCondition(p => p.ProviderId.Equals(providerId), trackChanges)
            .OrderBy(p => p.PhoneNumber)
            .ToListAsync();
    }
}
