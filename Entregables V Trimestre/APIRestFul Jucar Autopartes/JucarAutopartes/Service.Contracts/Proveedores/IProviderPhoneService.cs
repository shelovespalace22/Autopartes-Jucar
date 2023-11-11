using Shared.DataTransferObjects.Providers.ProviderPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Proveedores
{
    public interface IProviderPhoneService
    {
        /* Crear */
        ProviderPhoneDto CreatePhoneForProvider(Guid providerId, ProviderPhoneForCreationDto phone, bool trackChanges);

        /* Listar */
        IEnumerable<ProviderPhoneDto> GetPhones(Guid providerId, bool trackChanges);

        /* Un registro */
        ProviderPhoneDto GetPhoneForProvider(Guid providerId, Guid id, bool trackChanges);

        /* Actualizar */
        void UpdatePhoneForProvider(Guid providerId, Guid id, ProviderPhoneForUpdateDto phoneForUpdate, bool proTrackChanges, bool phoTrackChanges);

        /* Eliminar */
        void DeletePhoneForProvider(Guid providerId, Guid id, bool trackChanges);
    }
}
