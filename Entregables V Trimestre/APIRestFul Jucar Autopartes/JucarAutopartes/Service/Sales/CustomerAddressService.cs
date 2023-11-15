using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Sales;
using Entities.Models.Sales;
using Service.Contracts.Sales;
using Shared.DataTransferObjects.Sales.CustomerAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Sales
{
    internal sealed class CustomerAddressService : ICustomerAddressService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CustomerAddressService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public CustomerAddressDto CreateAddress(Guid customerId, CustomerAddressForCreationDto address, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var addressEntity = _mapper.Map<CustomerAddress>(address);

            _repository.CustomerAddress.CreateAddressForCustomer(customerId, addressEntity);

            _repository.Save();

            var addressToReturn = _mapper.Map<CustomerAddressDto>(addressEntity);

            return addressToReturn;
        }

        /* Eliminar */
        public void DeleteAddress(Guid customerId, Guid id, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var addressForCustomer = _repository.CustomerAddress.GetAddressByCustomer(customerId, id, trackChanges);

            if (addressForCustomer is null)
                throw new CustomerAddressNotFoundException(id);

            _repository.CustomerAddress.DeleteAddress(addressForCustomer);

            _repository.Save();
        }

        /* Un registro */
        public CustomerAddressDto GetAddress(Guid customerId, Guid id, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var addressDb = _repository.CustomerAddress.GetAddressByCustomer(customerId, id, trackChanges);

            if (addressDb is null)
                throw new CustomerAddressNotFoundException(id);

            var address = _mapper.Map<CustomerAddressDto>(addressDb);

            return address;
        }

        /* Listar */
        public IEnumerable<CustomerAddressDto> GetAddresses(Guid customerId, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var addressesFromDb = _repository.CustomerAddress.GetAddressesForCustomer(customerId, trackChanges);

            var addressDto = _mapper.Map<IEnumerable<CustomerAddressDto>>(addressesFromDb);

            return addressDto;
        }

        /* Actualizar */
        public void UpdateAddress(Guid customerId, Guid id, CustomerAddressForUpdateDto addressForUpdate, bool cusTrackChanges, bool adrTrackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, cusTrackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var addressEntity = _repository.CustomerAddress.GetAddressByCustomer(customerId, id, adrTrackChanges);

            if (addressEntity is null)
                throw new CustomerAddressNotFoundException(id);

            _mapper.Map(addressForUpdate, addressEntity);

            addressEntity.setModificationDate();

            _repository.Save();
        }
    }
}
