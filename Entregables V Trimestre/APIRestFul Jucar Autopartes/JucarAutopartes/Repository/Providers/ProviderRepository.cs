using Contracts.Providers;
using Entities.Models.Providers;
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
        public IEnumerable<Provider> GetAllProviders(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(p => p.Name)
            .ToList();

        /* Un registro */
        public Provider GetProvider(Guid providerId, bool trackChanges) =>
            FindByCondition(p => p.ProviderID.Equals(providerId), trackChanges)
            .SingleOrDefault();
    }
}
