using Shared.DataTransferObjects.Sales.CustomerPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Sales
{
    public interface ICustomerPhoneService
    {
        /* Crear */
        Task<CustomerPhoneDto> CreatePhoneAsync(Guid customerId, CustomerPhoneForCreationDto phone, bool trackChanges);

        /* Listar */
        Task<IEnumerable<CustomerPhoneDto>> GetPhonesAsync(Guid customerId, bool trackChanges);

        /* Un registro */
        Task<CustomerPhoneDto> GetPhoneAsync(Guid customerId, Guid id, bool trackChanges);

        /* Actualizar */
        Task UpdatePhoneAsync(Guid customerId, Guid id, CustomerPhoneForUpdateDto phoneForUpdate, bool cusTrackChanges, bool phoTrackChanges);

        /* Eliminar */
        Task DeletePhoneAsync(Guid customerId, Guid id, bool trackChanges);
    }
}
