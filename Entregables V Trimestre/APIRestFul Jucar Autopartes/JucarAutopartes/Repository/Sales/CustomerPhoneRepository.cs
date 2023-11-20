using Contracts.Sales;
using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sales
{
    public class CustomerPhoneRepository : RepositoryBase<CustomerPhone>, ICustomerPhoneRepository
    {
        public CustomerPhoneRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Crear */
        public void CreatePhoneForCustomer(Guid customerId, CustomerPhone customerPhone)
        {
            customerPhone.CustomerId = customerId;

            Create(customerPhone);
        }

        /* Eliminar */
        public void DeletePhone(CustomerPhone customerPhone) => Delete(customerPhone);

        /* Un registro */
        public CustomerPhone GetPhoneByCustomer(Guid customerId, Guid id, bool trackChanges) =>
            FindByCondition(c => c.CustomerId.Equals(customerId) && c.CustomerPhoneID.Equals(id), trackChanges)
            .SingleOrDefault();

        /* Listar */
        public IEnumerable<CustomerPhone> GetPhonesForCustomer(Guid customerId, bool trackChanges) =>
            FindByCondition(c => c.CustomerId.Equals(customerId), trackChanges)
            .OrderBy(c => c.PhoneNumber)
            .ToList();
    }
}
