using Contracts.Providers;
using Entities.Models.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Providers
{
    public class ProviderAddressRepository : RepositoryBase<ProviderAddress>, IProviderAddressRepository
    {
        public ProviderAddressRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Crear */
        public void CreateAddressForProvider(Guid providerId, ProviderAddress providerAddress)
        {
            providerAddress.ProviderId = providerId;

            Create(providerAddress);
        }

        /* Eliminar */
        public void DeleteProviderAddress(ProviderAddress providerAddress) => Delete(providerAddress);


        /* Un registro */
        public ProviderAddress GetAddressByProvider(Guid providerId, Guid id, bool trackChanges) =>
            FindByCondition(p => p.ProviderId.Equals(providerId) && p.ProviderAddressID.Equals(id), trackChanges)
            .SingleOrDefault();

        /* Listar */
        public IEnumerable<ProviderAddress> GetAddressesForProvider(Guid providerId, bool trackChanges) =>
            FindByCondition(p => p.ProviderId.Equals(providerId), trackChanges)
            .OrderBy(p => p.Neighborhood)
            .ToList();
    }
}
