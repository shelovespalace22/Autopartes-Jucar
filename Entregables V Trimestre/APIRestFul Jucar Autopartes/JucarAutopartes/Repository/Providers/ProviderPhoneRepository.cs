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

        /* Crear */
        public void CreatePhoneForProvider(Guid providerId, ProviderPhone providerPhone)
        {
            providerPhone.ProviderId = providerId;

            Create(providerPhone);
        }


        /* Eliminar */
        public void DeleteProviderPhone(ProviderPhone providerPhone) => Delete(providerPhone);


        /* Un registro */
        public ProviderPhone GetPhoneByProvider(Guid providerId, Guid id, bool trackChanges) =>
            FindByCondition(p => p.ProviderId.Equals(providerId) && p.ProviderPhoneID.Equals(id), trackChanges)
            .SingleOrDefault();


        /* Listar */
        public IEnumerable<ProviderPhone> GetPhonesForProvider(Guid providerId, bool trackChanges) =>
            FindByCondition(p => p.ProviderId.Equals(providerId), trackChanges)
            .OrderBy(p => p.PhoneNumber)
            .ToList();
    }
}
