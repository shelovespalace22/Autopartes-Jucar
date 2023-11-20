using Shared.DataTransferObjects.Sales.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Sales
{
    public interface ICustomerService
    {
        /* Crear */
        CustomerDto CreateCustomer(CustomerForCreationDto customer);

        /* Listar */
        IEnumerable<CustomerDto> GetAllCustomers(bool trackChanges);

        /* Un registro */
        CustomerDto GetCustomer(Guid customerId, bool trackChanges);

        /* Actualizar */
        void UpdateCustomer(Guid customerId, CustomerForUpdateDto customerForUpdate, bool trackChanges);

        /* Eliminar */
        void DeleteCustomer(Guid customerId, bool trackChanges);
    }
}
