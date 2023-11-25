using Entities.Models.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Providers
{
    public interface IProviderRepository
    {
        /* Crear */
        void CreateProvider(Provider provider);

        /* Listar */
        Task<IEnumerable<Provider>> GetAllProvidersAsync(bool trackChanges);

        /* Un registro */
        Task<Provider> GetProviderAsync(Guid providerId, bool trackChanges);

        /* Eliminar */
        void DeleteProvider(Provider provider);
    }
}
