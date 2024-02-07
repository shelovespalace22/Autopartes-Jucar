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
        Task<CustomerDto> CreateCustomerAsync(CustomerForCreationDto customer);

        /* Listar */
        Task<IEnumerable<CustomerDto>> GetAllCustomersAsync(bool trackChanges);

        /* Un registro */
        Task<CustomerDto> GetCustomerAsync(Guid customerId, bool trackChanges);

        /* Actualizar */
        Task UpdateCustomerAsync(Guid customerId, CustomerForUpdateDto customerForUpdate, bool trackChanges);

        /* Eliminar */
        Task DeleteCustomerAsync(Guid customerId, bool trackChanges);
    }
}
