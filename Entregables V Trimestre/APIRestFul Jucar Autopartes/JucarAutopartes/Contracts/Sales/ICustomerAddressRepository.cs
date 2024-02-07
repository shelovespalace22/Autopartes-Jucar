using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Sales
{
    public interface ICustomerAddressRepository
    {
        /* Crear */
        void CreateAddressForCustomer(Guid customerId, CustomerAddress customerAddress);

        /* Listar */
        Task<IEnumerable<CustomerAddress>> GetAddressesForCustomerAsync(Guid customerId, bool trackChanges);

        /* Un registro */
        Task<CustomerAddress> GetAddressByCustomerAsync(Guid customerId, Guid id, bool trackChanges);

        /* Eliminar */
        void DeleteAddress(CustomerAddress customerAddress);
    }
}
