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
    public class ProviderRepository : RepositoryBase<Provider>, IProviderRepository
    {
        public ProviderRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Crear */
        public void CreateProvider(Provider provider) => Create(provider);

        /* Eliminar */
        public void DeleteProvider(Provider provider) => Delete(provider);

        /* Listar */
        public async Task<IEnumerable<Provider>> GetAllProvidersAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(p => p.Name)
            .ToListAsync();

        /* Un registro */
        public async Task<Provider> GetProviderAsync(Guid providerId, bool trackChanges) =>
            await FindByCondition(p => p.ProviderID.Equals(providerId), trackChanges)
            .SingleOrDefaultAsync();
    }
}
