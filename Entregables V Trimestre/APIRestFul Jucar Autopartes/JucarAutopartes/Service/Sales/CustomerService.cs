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
        public async Task<CustomerDto> CreateCustomerAsync(CustomerForCreationDto customer)
        {
            var customerEntity = _mapper.Map<Customer>(customer);

            _repository.Customer.CreateCustomer(customerEntity);

            await _repository.SaveAsync();

            var customerToReturn = _mapper.Map<CustomerDto>(customerEntity);

            return customerToReturn;
        }

        /* Eliminar */
        public async Task DeleteCustomerAsync(Guid customerId, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            _repository.Customer.DeleteCustomer(customer);

            await _repository.SaveAsync();
                
        }

        /* Listar */
        public async Task<IEnumerable<CustomerDto>> GetAllCustomersAsync(bool trackChanges)
        {
            var customers = await _repository.Customer.GetAllCustomersAsync(trackChanges);

            var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            return customersDto;
        }

        /* Un registro */
        public async Task<CustomerDto> GetCustomerAsync(Guid customerId, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            var customerDto = _mapper.Map<CustomerDto>(customer);

            return customerDto;
        }

        /* Actualizar */
        public async Task UpdateCustomerAsync(Guid customerId, CustomerForUpdateDto customerForUpdate, bool trackChanges)
        {
            var customerEntity = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customerEntity is null)
                throw new CustomerNotFoundException(customerId);

            _mapper.Map(customerForUpdate, customerEntity);

            customerEntity.setModificationDate();

            await _repository.SaveAsync();
        }
    }
}
