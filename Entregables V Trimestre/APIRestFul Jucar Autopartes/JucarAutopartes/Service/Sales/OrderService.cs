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
        public OrderDto CreateOrder(OrderForCreationDto order)
        {
            ApplyAdditionalOperations(order, _repository);

            var orderEntity = _mapper.Map<Order>(order);

            _repository.Order.CreateOrder(orderEntity);

            _repository.Save();

            var orderToReturn = _mapper.Map<OrderDto>(orderEntity);

            return orderToReturn;
        }

        /* Eliminar */
        public void DeleteOrder(Guid orderId, bool trackChanges)
        {
            var order = _repository.Order.GetOrder(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            _repository.Order.DeleteOrder(order);

            _repository.Save();
        }

        /* Listar */
        public IEnumerable<OrderDto> GetAllOrders(bool trackChanges)
        {
            var orders = _repository.Order.GetAllOrders(trackChanges);

            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);

            return ordersDto;
        }

        /* Un registro */
        public OrderDto GetOrder(Guid orderId, bool trackChanges)
        {
            var order = _repository.Order.GetOrder(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var orderDto = _mapper.Map<OrderDto>(order);

            return orderDto;
        }

        /* Actualizar */
        public void UpdateOrder(Guid orderId, OrderForUpdateDto orderForUpdate, bool trackChanges)
        {
            var orderEntity = _repository.Order.GetOrder(orderId, trackChanges);

            if (orderEntity is null)
                throw new OrderNotFoundException(orderId);

            _mapper.Map(orderForUpdate, orderEntity);

            orderEntity.setModificationDate();

            _repository.Save();
        }





        /* <--- Métodos Privados ---> */

        private void ApplyAdditionalOperations(OrderForCreationDto order, IRepositoryManager _repository)
        {
            foreach (var orderDetail in order.OrderDetails)
            {
                var autopart = _repository.Autopart.GetAutopartById(orderDetail.AutopartId, false);

                orderDetail.UnitValue = autopart.Value;

                orderDetail.SubtotalValue = orderDetail.Quantity * orderDetail.UnitValue.Value;
            }

            // Calcular el Total sumando los SubtotalValue de cada detalle
            order.Total = order.OrderDetails.Sum(detail => detail.SubtotalValue ?? 0);

            //order.Total = order.OrderDetails.Sum(detail => detail.SubtotalValue.GetValueOrDefault());
            //order = order with { Total = order.OrderDetails.Sum(detail => detail.SubtotalValue.GetValueOrDefault()) };

            _repository.Save();
        }
            
    }
}
