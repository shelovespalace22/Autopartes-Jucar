using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Sales;
using Entities.Models.Sales;
using Service.Contracts.Sales;
using Shared.DataTransferObjects.Sales.CustomerPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Sales
{
    internal sealed class CustomerPhoneService : ICustomerPhoneService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CustomerPhoneService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public async Task<CustomerPhoneDto> CreatePhoneAsync(Guid customerId, CustomerPhoneForCreationDto phone, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var phoneEntity = _mapper.Map<CustomerPhone>(phone);

            _repository.CustomerPhone.CreatePhoneForCustomer(customerId, phoneEntity);

            await _repository.SaveAsync();

            var phoneToReturn = _mapper.Map<CustomerPhoneDto>(phoneEntity);

            return phoneToReturn;
        }

        /* Eliminar */
        public async Task DeletePhoneAsync(Guid customerId, Guid id, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var phoneForCustomer = await _repository.CustomerPhone.GetPhoneByCustomerAsync(customerId, id, trackChanges);

            if (phoneForCustomer is null)
                throw new CustomerPhoneNotFoundException(id);

            _repository.CustomerPhone.DeletePhone(phoneForCustomer);

            await _repository.SaveAsync();
        }

        /* Un registro */
        public async Task<CustomerPhoneDto> GetPhoneAsync(Guid customerId, Guid id, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var phoneDb = await _repository.CustomerPhone.GetPhoneByCustomerAsync(customerId, id, trackChanges);

            if (phoneDb is null)
                throw new CustomerPhoneNotFoundException(id);

            var phone = _mapper.Map<CustomerPhoneDto>(phoneDb);

            return phone;
        }

        /* Listar */
        public async Task<IEnumerable<CustomerPhoneDto>> GetPhonesAsync(Guid customerId, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var phonesFromDb = await _repository.CustomerPhone.GetPhonesForCustomerAsync(customerId, trackChanges);

            var phonesDto = _mapper.Map<IEnumerable<CustomerPhoneDto>>(phonesFromDb);

            return phonesDto;
        }

        /* Actualizar */
        public async Task UpdatePhoneAsync(Guid customerId, Guid id, CustomerPhoneForUpdateDto phoneForUpdate, bool cusTrackChanges, bool phoTrackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, cusTrackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var phoneEntity = await _repository.CustomerPhone.GetPhoneByCustomerAsync(customerId, id, phoTrackChanges);

            if (phoneEntity is null)
                throw new CustomerPhoneNotFoundException(id);

            _mapper.Map(phoneForUpdate, phoneEntity);

            phoneEntity.setModificationDate();

            await _repository.SaveAsync();
        }
    }
}
