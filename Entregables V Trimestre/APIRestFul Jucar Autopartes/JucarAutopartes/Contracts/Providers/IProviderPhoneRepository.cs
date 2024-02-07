using Entities.Models.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Providers
{
    public interface IProviderPhoneRepository
    {
        /* Crear */
        void CreatePhoneForProvider(Guid providerId, ProviderPhone providerPhone);

        /* Listar */
        Task<IEnumerable<ProviderPhone>> GetPhonesForProviderAsync(Guid providerId, bool trackChanges);

        /* Un registro */
        Task<ProviderPhone> GetPhoneByProviderAsync(Guid providerId, Guid id, bool trackChanges);

        /* Eliminar */
        void DeleteProviderPhone(ProviderPhone providerPhone);
    }
}
