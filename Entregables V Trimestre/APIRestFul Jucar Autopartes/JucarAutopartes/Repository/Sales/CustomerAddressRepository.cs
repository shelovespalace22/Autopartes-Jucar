using Contracts.Sales;
using Entities.Models.Sales;
using Microsoft.EntityFrameworkCore;
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
        public async Task<CustomerAddress> GetAddressByCustomerAsync(Guid customerId, Guid id, bool trackChanges) =>
            await FindByCondition(c => c.CustomerId.Equals(customerId) && c.CustomerAddressID.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        /* Listar */
        public async Task<IEnumerable<CustomerAddress>> GetAddressesForCustomerAsync(Guid customerId, bool trackChanges) =>
            await FindByCondition(c => c.CustomerId.Equals(customerId), trackChanges)
            .Include(c => c.Neighborhood)
            .OrderBy(c => c.Neighborhood.Name)
            .ToListAsync();
    }
}
