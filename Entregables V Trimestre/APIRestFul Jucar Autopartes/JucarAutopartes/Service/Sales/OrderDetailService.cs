using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Sales;
using Service.Contracts.Sales;
using Shared.DataTransferObjects.Sales.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Sales
{
    internal sealed class OrderDetailService : IOrderDetailService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public OrderDetailService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Listar */
        public async Task<IEnumerable<OrderDetailDto>> GetDetailsForOrderAsync(Guid orderId, bool trackChanges)
        {
            var order = await _repository.Order.GetOrderAsync(orderId, trackChanges);

            if (order is null)
                throw new OrderNotFoundException(orderId);

            var detailsFromDb = await _repository.OrderDetail.GetOrderDetailsAsync(orderId, trackChanges);

            var detailsDto = _mapper.Map<IEnumerable<OrderDetailDto>>(detailsFromDb);

            return detailsDto;
        }
    }
}
