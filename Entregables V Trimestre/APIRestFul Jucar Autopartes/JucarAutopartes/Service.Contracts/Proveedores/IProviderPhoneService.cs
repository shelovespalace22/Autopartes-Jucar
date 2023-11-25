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
        Task<ProviderPhoneDto> CreatePhoneForProviderAsync(Guid providerId, ProviderPhoneForCreationDto phone, bool trackChanges);

        /* Listar */
        Task<IEnumerable<ProviderPhoneDto>> GetPhonesAsync(Guid providerId, bool trackChanges);

        /* Un registro */
        Task<ProviderPhoneDto> GetPhoneForProviderAsync(Guid providerId, Guid id, bool trackChanges);

        /* Actualizar */
        Task UpdatePhoneForProviderAsync(Guid providerId, Guid id, ProviderPhoneForUpdateDto phoneForUpdate, bool proTrackChanges, bool phoTrackChanges);

        /* Eliminar */
        Task DeletePhoneForProviderAsync(Guid providerId, Guid id, bool trackChanges);
    }
}
