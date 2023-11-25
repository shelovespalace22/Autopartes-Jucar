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
        public async Task<CustomerAddressDto> CreateAddressAsync(Guid customerId, CustomerAddressForCreationDto address, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var addressEntity = _mapper.Map<CustomerAddress>(address);

            _repository.CustomerAddress.CreateAddressForCustomer(customerId, addressEntity);

            await _repository.SaveAsync();

            var addressToReturn = _mapper.Map<CustomerAddressDto>(addressEntity);

            return addressToReturn;
        }

        /* Eliminar */
        public async Task DeleteAddressAsync(Guid customerId, Guid id, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var addressForCustomer = await _repository.CustomerAddress.GetAddressByCustomerAsync(customerId, id, trackChanges);

            if (addressForCustomer is null)
                throw new CustomerAddressNotFoundException(id);

            _repository.CustomerAddress.DeleteAddress(addressForCustomer);

            _repository.SaveAsync();
        }

        /* Un registro */
        public async Task<CustomerAddressDto> GetAddressAsync(Guid customerId, Guid id, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var addressDb = await _repository.CustomerAddress.GetAddressByCustomerAsync(customerId, id, trackChanges);

            if (addressDb is null)
                throw new CustomerAddressNotFoundException(id);

            var address = _mapper.Map<CustomerAddressDto>(addressDb);

            return address;
        }

        /* Listar */
        public async Task<IEnumerable<CustomerAddressDto>> GetAddressesAsync(Guid customerId, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var addressesFromDb = await _repository.CustomerAddress.GetAddressesForCustomerAsync(customerId, trackChanges);

            var addressDto = _mapper.Map<IEnumerable<CustomerAddressDto>>(addressesFromDb);

            return addressDto;
        }

        /* Actualizar */
        public async Task UpdateAddressAsync(Guid customerId, Guid id, CustomerAddressForUpdateDto addressForUpdate, bool cusTrackChanges, bool adrTrackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, cusTrackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var addressEntity = await _repository.CustomerAddress.GetAddressByCustomerAsync(customerId, id, adrTrackChanges);

            if (addressEntity is null)
                throw new CustomerAddressNotFoundException(id);

            _mapper.Map(addressForUpdate, addressEntity);

            addressEntity.setModificationDate();

            await _repository.SaveAsync();
        }
    }
}
