using Contracts.Sales;
using Entities.Models.Sales;
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
        public IEnumerable<Customer> GetAllCustomers(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        /* Un registro */
        public Customer GetCustomer(Guid customerId, bool trackChanges) =>
            FindByCondition(c => c.CustomerID.Equals(customerId), trackChanges)
            .SingleOrDefault();
    }
}
