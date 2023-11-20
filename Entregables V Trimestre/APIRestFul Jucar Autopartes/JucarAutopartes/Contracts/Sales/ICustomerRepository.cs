using Entities.Models.Providers;
using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Sales
{
    public interface ICustomerRepository
    {
        /* Crear */
        void CreateCustomer(Customer customer);

        /* Listar */
        IEnumerable<Customer> GetAllCustomers(bool trackChanges);

        /* Un registro */
        Customer GetCustomer(Guid customerId, bool trackChanges);

        /* Eliminar */
        void DeleteCustomer(Customer customer);
    }
}
