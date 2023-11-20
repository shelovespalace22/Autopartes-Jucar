using Contracts.Sales;
using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sales
{
    public class CustomerAddressRepository : RepositoryBase<CustomerAddress>, ICustomerAddressRepository
    {
        public CustomerAddressRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            
        }
        /* Crear */

        public void CreateAddressForCustomer(Guid customerId, CustomerAddress customerAddress)
        {
            customerAddress.CustomerId = customerId;

            Create(customerAddress);
        }

        /* Eliminar */
        public void DeleteAddress(CustomerAddress customerAddress) => Delete(customerAddress);

        /* Un registro */
        public CustomerAddress GetAddressByCustomer(Guid customerId, Guid id, bool trackChanges) =>
            FindByCondition(c => c.CustomerId.Equals(customerId) && c.CustomerAddressID.Equals(id), trackChanges)
            .SingleOrDefault();

        /* Listar */
        public IEnumerable<CustomerAddress> GetAddressesForCustomer(Guid customerId, bool trackChanges) =>
            FindByCondition(c => c.CustomerId.Equals(customerId), trackChanges)
            .OrderBy(c => c.Address)
            .ToList();
    }
}
