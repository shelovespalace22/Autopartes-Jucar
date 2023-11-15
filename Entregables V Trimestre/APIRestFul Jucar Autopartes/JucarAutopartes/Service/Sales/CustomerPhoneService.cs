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
        public CustomerPhoneDto CreatePhone(Guid customerId, CustomerPhoneForCreationDto phone, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var phoneEntity = _mapper.Map<CustomerPhone>(phone);

            _repository.CustomerPhone.CreatePhoneForCustomer(customerId, phoneEntity);

            _repository.Save();

            var phoneToReturn = _mapper.Map<CustomerPhoneDto>(phoneEntity);

            return phoneToReturn;
        }

        /* Eliminar */
        public void DeletePhone(Guid customerId, Guid id, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var phoneForCustomer = _repository.CustomerPhone.GetPhoneByCustomer(customerId, id, trackChanges);

            if (phoneForCustomer is null)
                throw new CustomerPhoneNotFoundException(id);

            _repository.CustomerPhone.DeletePhone(phoneForCustomer);

            _repository.Save();
        }

        /* Un registro */
        public CustomerPhoneDto GetPhone(Guid customerId, Guid id, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var phoneDb = _repository.CustomerPhone.GetPhoneByCustomer(customerId, id, trackChanges);

            if (phoneDb is null)
                throw new CustomerPhoneNotFoundException(id);

            var phone = _mapper.Map<CustomerPhoneDto>(phoneDb);

            return phone;
        }

        /* Listar */
        public IEnumerable<CustomerPhoneDto> GetPhones(Guid customerId, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var phonesFromDb = _repository.CustomerPhone.GetPhonesForCustomer(customerId, trackChanges);

            var phonesDto = _mapper.Map<IEnumerable<CustomerPhoneDto>>(phonesFromDb);

            return phonesDto;
        }

        /* Actualizar */
        public void UpdatePhone(Guid customerId, Guid id, CustomerPhoneForUpdateDto phoneForUpdate, bool cusTrackChanges, bool phoTrackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, cusTrackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var phoneEntity = _repository.CustomerPhone.GetPhoneByCustomer(customerId, id, phoTrackChanges);

            if (phoneEntity is null)
                throw new CustomerPhoneNotFoundException(id);

            _mapper.Map(phoneForUpdate, phoneEntity);

            phoneEntity.setModificationDate();

            _repository.Save();
        }
    }
}
