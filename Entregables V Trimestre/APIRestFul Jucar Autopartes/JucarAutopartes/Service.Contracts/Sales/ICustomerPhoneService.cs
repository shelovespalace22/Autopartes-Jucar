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
        CustomerPhoneDto CreatePhone(Guid customerId, CustomerPhoneForCreationDto phone, bool trackChanges);

        /* Listar */
        IEnumerable<CustomerPhoneDto> GetPhones(Guid customerId, bool trackChanges);

        /* Un registro */
        CustomerPhoneDto GetPhone(Guid customerId, Guid id, bool trackChanges);

        /* Actualizar */
        void UpdatePhone(Guid customerId, Guid id, CustomerPhoneForUpdateDto phoneForUpdate, bool cusTrackChanges, bool phoTrackChanges);

        /* Eliminar */
        void DeletePhone(Guid customerId, Guid id, bool trackChanges);
    }
}
