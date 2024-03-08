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
        public async Task<ProviderAddress> GetAddressByProviderAsync(Guid providerId, Guid id, bool trackChanges) =>
            await FindByCondition(p => p.ProviderId.Equals(providerId) && p.ProviderAddressID.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        /* Listar */
        public async Task<IEnumerable<ProviderAddress>> GetAddressesForProviderAsync(Guid providerId, bool trackChanges) =>
            await FindByCondition(p => p.ProviderId.Equals(providerId), trackChanges)
            .Include(p => p.Neighborhood) // Incluir la información del barrio
            .OrderBy(p => p.Neighborhood.Name) // Ordenar por nombre del barrio si es necesario
            .ToListAsync();
    }
}
