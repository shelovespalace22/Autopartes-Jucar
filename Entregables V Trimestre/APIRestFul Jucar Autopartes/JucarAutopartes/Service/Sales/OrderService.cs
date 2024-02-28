using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Sales;
using Entities.Models.Sales;
using Service.Contracts.Sales;
using Shared.DataTransferObjects.Sales.Order;
using Shared.DataTransferObjects.Sales.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Sales
{
    internal sealed class OrderService : IOrderService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public OrderService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public async Task<OrderDto> CreateOrderAsync(Guid customerId, OrderForCreationDto order, bool trackChanges)
        {
            await CheckIfCustomerExists(customerId, trackChanges);

            await ApplyAdditionalOperations(order, _repository);

            var orderEntity = _mapper.Map<Order>(order);

            _repository.Order.CreateOrder(customerId, orderEntity);

            await _repository.SaveAsync();

            var orderToReturn = _mapper.Map<OrderDto>(orderEntity);

            return orderToReturn;
        }

        /* Eliminar */
        public async Task DeleteOrderAsync(Guid customerId, Guid orderId, bool trackChanges)
        {
            await CheckIfCustomerExists(customerId, trackChanges);

            var order = await GetOrderAndCheckIfItExists(customerId, orderId, trackChanges);

            _repository.Order.DeleteOrder(order);

            await _repository.SaveAsync();
        }

        /* Listar */
        public async Task<IEnumerable<OrderDto>> GetAllOrdersAsync(Guid customerId, bool trackChanges)
        {
            await CheckIfCustomerExists(customerId, trackChanges);

            var orders = await _repository.Order.GetAllOrdersAsync(customerId, trackChanges);

            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);

            return ordersDto;
        }

        /* Un registro */
        public async Task<OrderDto> GetOrderAsync(Guid customerId, Guid orderId, bool trackChanges)
        {
            await CheckIfCustomerExists(customerId, trackChanges);

            var order = await GetOrderAndCheckIfItExists(customerId, orderId, trackChanges);

            var orderDto = _mapper.Map<OrderDto>(order);

            return orderDto;
        }

        /* Actualizar */
        public async Task UpdateOrderAsync(Guid customerId, Guid orderId, OrderForUpdateDto orderForUpdate, bool cusTrackChanges, bool ordTrackChanges)
        {
            await CheckIfCustomerExists(customerId, cusTrackChanges);

            var orderEntity = await GetOrderAndCheckIfItExists(customerId, orderId, ordTrackChanges);

            _mapper.Map(orderForUpdate, orderEntity);

            orderEntity.setModificationDate();

            await _repository.SaveAsync();
        }





        /* <--- Métodos Privados ---> */

        private async Task ApplyAdditionalOperations(OrderForCreationDto order, IRepositoryManager _repository)
        {
            foreach (var orderDetail in order.OrderDetails)
            {
                var autopart = await _repository.Autopart.GetAutopartByIdAsync(orderDetail.AutopartId, false);

                orderDetail.UnitValue = autopart.Value;

                orderDetail.SubtotalValue = orderDetail.Quantity * orderDetail.UnitValue.Value;
            }

            // Calcular el Total sumando los SubtotalValue de cada detalle
            order.Total = order.OrderDetails.Sum(detail => detail.SubtotalValue ?? 0);

            //order.Total = order.OrderDetails.Sum(detail => detail.SubtotalValue.GetValueOrDefault());
            //order = order with { Total = order.OrderDetails.Sum(detail => detail.SubtotalValue.GetValueOrDefault()) };

            await _repository.SaveAsync();
        }

        private async Task<Order> GetOrderAndCheckIfItExists(Guid customerId, Guid id, bool trackChanges)
        {
            var order = await _repository.Order.GetOrderByCustomerAsync(customerId, id, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(id);

            return order;
        }

        private async Task<Customer> CheckIfCustomerExists(Guid customerId, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);

            if (customer is null)
                throw new CustomerNotFoundException(customerId);

            return customer;
        }

    }
}
