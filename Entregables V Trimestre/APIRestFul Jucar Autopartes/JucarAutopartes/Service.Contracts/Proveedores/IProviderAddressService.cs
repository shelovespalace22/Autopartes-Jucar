using Shared.DataTransferObjects.Providers.ProviderAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Proveedores
{
    public interface IProviderAddressService
    {
        /* Crear */
        Task<ProviderAddressDto> CreateAddressForProviderAsync(Guid providerId, ProviderAddressForCreationDto address, bool trackChanges);

        /* Listar */
        Task<IEnumerable<ProviderAddressDto>> GetAddressesAsync(Guid providerId, bool trackChanges);

        /* Un registro */
        Task<ProviderAddressDto> GetAddressForProviderAsync(Guid providerId, Guid id, bool trackChanges);

        /* Actualizar */
        Task UpdateAddressForProviderAsync(Guid providerId, Guid id, ProviderAddressForUpdateDto addressForUpdate, bool proTrackChanges, bool adrTrackChanges);

        /* Eliminar */
        Task DeleteAddressForProviderAsync(Guid providerId, Guid id, bool trackChanges);
    }
}
