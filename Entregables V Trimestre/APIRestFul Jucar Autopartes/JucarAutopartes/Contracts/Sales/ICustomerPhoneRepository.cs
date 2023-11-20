using Entities.Models.Providers;
using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Sales
{
    public interface ICustomerPhoneRepository
    {
        /* Crear */
        void CreatePhoneForCustomer(Guid customerId, CustomerPhone customerPhone);

        /* Listar */
        IEnumerable<CustomerPhone> GetPhonesForCustomer(Guid customerId, bool trackChanges);

        /* Un registro */
        CustomerPhone GetPhoneByCustomer(Guid customerId, Guid id, bool trackChanges);

        /* Eliminar */
        void DeletePhone(CustomerPhone customerPhone);
    }
}
