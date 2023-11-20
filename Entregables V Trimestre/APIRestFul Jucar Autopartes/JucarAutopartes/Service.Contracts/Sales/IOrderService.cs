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
        OrderDto CreateOrder(OrderForCreationDto order);

        /* Listar */
        IEnumerable<OrderDto> GetAllOrders(bool trackChanges);

        /* Un registro */
        OrderDto GetOrder(Guid orderId, bool trackChanges);

        /* Actualizar */
        void UpdateOrder(Guid orderId, OrderForUpdateDto orderForUpdate, bool trackChanges);

        /* Eliminar */
        void DeleteOrder(Guid orderId, bool trackChanges);
    }
}
