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
        Task<IEnumerable<Customer>> GetAllCustomersAsync(bool trackChanges);

        /* Un registro */
        Task<Customer> GetCustomerAsync(Guid customerId, bool trackChanges);

        /* Eliminar */
        void DeleteCustomer(Customer customer);
    }
}
