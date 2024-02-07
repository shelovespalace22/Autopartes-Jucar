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
        Task<OrderDto> CreateOrderAsync(OrderForCreationDto order);

        /* Listar */
        Task<IEnumerable<OrderDto>> GetAllOrdersAsync(bool trackChanges);

        /* Un registro */
        Task<OrderDto> GetOrderAsync(Guid orderId, bool trackChanges);

        /* Actualizar */
        Task UpdateOrderAsync(Guid orderId, OrderForUpdateDto orderForUpdate, bool trackChanges);

        /* Eliminar */
        Task DeleteOrderAsync(Guid orderId, bool trackChanges);
    }
}
