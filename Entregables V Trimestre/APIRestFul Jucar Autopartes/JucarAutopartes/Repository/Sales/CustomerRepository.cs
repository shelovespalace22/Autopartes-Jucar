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
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Crear */
        public void CreateCustomer(Customer customer) => Create(customer);

        /* Eliminar */
        public void DeleteCustomer(Customer customer) => Delete(customer);

        /* Listar */
        public async Task<IEnumerable<Customer>> GetAllCustomersAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();

        /* Un registro */
        public async Task<Customer> GetCustomerAsync(Guid customerId, bool trackChanges) =>
            await FindByCondition(c => c.CustomerID.Equals(customerId), trackChanges)
            .SingleOrDefaultAsync();
    }
}
