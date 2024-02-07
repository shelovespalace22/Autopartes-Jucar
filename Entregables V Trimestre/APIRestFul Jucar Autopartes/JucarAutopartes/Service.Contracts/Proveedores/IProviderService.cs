using Shared.DataTransferObjects.Providers.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Proveedores
{
    public interface IProviderService
    {
        /* Crear */
        Task<ProviderDto> CreateProviderAsync(ProviderForCreationDto provider);

        /* Listar */
        Task<IEnumerable<ProviderDto>> GetAllProvidersAsync(bool trackChanges);

        /* Un registro */
        Task<ProviderDto> GetProviderAsync(Guid providerId, bool trackChanges);

        /* Actualizar */
        Task UpdateProviderAsync(Guid providerId, ProviderForUpdateDto providerForUpdate, bool trackChanges);

        /* Eliminar */
        Task DeleteProviderAsync(Guid providerId, bool trackChanges);
    }   
}
