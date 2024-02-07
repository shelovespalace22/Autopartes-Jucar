using Entities.Models.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Providers
{
    public interface IProviderAddressRepository
    {
        /* Crear */
        void CreateAddressForProvider(Guid providerId, ProviderAddress providerAddress);

        /* Listar */
        Task<IEnumerable<ProviderAddress>> GetAddressesForProviderAsync(Guid providerId, bool trackChanges);

        /* Un registro */
        Task<ProviderAddress> GetAddressByProviderAsync(Guid providerId, Guid id, bool trackChanges);

        /* Eliminar */
        void DeleteProviderAddress(ProviderAddress providerAddress);
    }
}
