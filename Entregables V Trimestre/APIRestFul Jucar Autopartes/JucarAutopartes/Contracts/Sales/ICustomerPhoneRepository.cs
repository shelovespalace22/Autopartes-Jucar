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
        Task<IEnumerable<CustomerPhone>> GetPhonesForCustomerAsync(Guid customerId, bool trackChanges);

        /* Un registro */
        Task<CustomerPhone> GetPhoneByCustomerAsync(Guid customerId, Guid id, bool trackChanges);

        /* Eliminar */
        void DeletePhone(CustomerPhone customerPhone);
    }
}
