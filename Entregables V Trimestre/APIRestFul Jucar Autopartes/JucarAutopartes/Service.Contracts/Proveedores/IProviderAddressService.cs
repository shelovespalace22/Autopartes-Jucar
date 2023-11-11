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
        ProviderAddressDto CreateAddressForProvider(Guid providerId, ProviderAddressForCreationDto address, bool trackChanges);

        /* Listar */
        IEnumerable<ProviderAddressDto> GetAddresses(Guid providerId, bool trackChanges);

        /* Un registro */
        ProviderAddressDto GetAddressForProvider(Guid providerId, Guid id, bool trackChanges);

        /* Actualizar */
        void UpdateAddressForProvider(Guid providerId, Guid id, ProviderAddressForUpdateDto addressForUpdate, bool proTrackChanges, bool adrTrackChanges);

        /* Eliminar */
        void DeleteAddressForProvider(Guid providerId, Guid id, bool trackChanges);
    }
}
