using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Sales;
using Entities.Models.Sales;
using Service.Contracts;
using Service.Contracts.Sales;
using Shared.DataTransferObjects.Sales.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Sales
{
    internal sealed class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CustomerService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public CustomerDto CreateCustomer(CustomerForCreationDto customer)
        {
            var customerEntity = _mapper.Map<Customer>(customer);

            _repository.Customer.CreateCustomer(customerEntity);

            _repository.Save();

            var customerToReturn = _mapper.Map<CustomerDto>(customerEntity);

            return customerToReturn;
        }

        /* Eliminar */
        public void DeleteCustomer(Guid customerId, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            _repository.Customer.DeleteCustomer(customer);

            _repository.Save();
                
        }

        /* Listar */
        public IEnumerable<CustomerDto> GetAllCustomers(bool trackChanges)
        {
            var customers = _repository.Customer.GetAllCustomers(trackChanges);

            var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            return customersDto;
        }

        /* Un registro */
        public CustomerDto GetCustomer(Guid customerId, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var customerDto = _mapper.Map<CustomerDto>(customer);

            return customerDto;
        }

        /* Actualizar */
        public void UpdateCustomer(Guid customerId, CustomerForUpdateDto customerForUpdate, bool trackChanges)
        {
            var customerEntity = _repository.Customer.GetCustomer(customerId, trackChanges);

            if (customerEntity is null)
                throw new CustomerNotFoundException(customerId);

            _mapper.Map(customerForUpdate, customerEntity);

            customerEntity.setModificationDate();

            _repository.Save();
        }
    }
}
