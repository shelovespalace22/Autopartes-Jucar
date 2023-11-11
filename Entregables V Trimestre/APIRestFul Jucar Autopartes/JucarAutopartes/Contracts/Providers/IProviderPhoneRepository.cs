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
        IEnumerable<ProviderPhone> GetPhonesForProvider(Guid providerId, bool trackChanges);

        /* Un registro */
        ProviderPhone GetPhoneByProvider(Guid providerId, Guid id, bool trackChanges);

        /* Eliminar */
        void DeleteProviderPhone(ProviderPhone providerPhone);
    }
}
