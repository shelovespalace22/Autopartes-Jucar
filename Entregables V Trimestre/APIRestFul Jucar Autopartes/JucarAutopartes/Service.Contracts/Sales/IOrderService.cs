using Shared.DataTransferObjects.Providers.Provider;
using Shared.DataTransferObjects.Sales.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Sales
{
    public interface IOrderService
    {
        /* Crear */
        Task<OrderDto> CreateOrderAsync(Guid customerId, OrderForCreationDto order, bool trackChanges);

        /* Listar */
        Task<IEnumerable<OrderDto>> GetAllOrdersAsync(Guid customerId, bool trackChanges);

        /* Un registro */
        Task<OrderDto> GetOrderAsync(Guid customerId, Guid orderId, bool trackChanges);

        /* Actualizar */
        Task UpdateOrderAsync(Guid customerId, Guid orderId, OrderForUpdateDto orderForUpdate, bool cusTrackChanges, bool ordTrackChanges);

        /* Eliminar */
        Task DeleteOrderAsync(Guid customerId, Guid orderId, bool trackChanges);
    }
}
