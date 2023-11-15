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
        CustomerAddressDto CreateAddress(Guid customerId, CustomerAddressForCreationDto address, bool trackChanges);

        /* Listar */
        IEnumerable<CustomerAddressDto> GetAddresses(Guid customerId, bool trackChanges);

        /* Un registro */
        CustomerAddressDto GetAddress(Guid customerId, Guid id, bool trackChanges);

        /* Actualizar */
        void UpdateAddress(Guid customerId, Guid id, CustomerAddressForUpdateDto addressForUpdate, bool cusTrackChanges, bool adrTrackChanges);

        /* Eliminar */
        void DeleteAddress(Guid customerId, Guid id, bool trackChanges);
    }
}
