using Shared.DataTransferObjects.Sales.CustomerAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Sales
{
    public interface ICustomerAddressService
    {
        /* Crear */
        Task<CustomerAddressDto> CreateAddressAsync(Guid customerId, CustomerAddressForCreationDto address, bool trackChanges);

        /* Listar */
        Task<IEnumerable<CustomerAddressDto>> GetAddressesAsync(Guid customerId, bool trackChanges);

        /* Un registro */
        Task<CustomerAddressDto> GetAddressAsync(Guid customerId, Guid id, bool trackChanges);

        /* Actualizar */
        Task UpdateAddressAsync(Guid customerId, Guid id, CustomerAddressForUpdateDto addressForUpdate, bool cusTrackChanges, bool adrTrackChanges);

        /* Eliminar */
        Task DeleteAddressAsync(Guid customerId, Guid id, bool trackChanges);
    }
}
