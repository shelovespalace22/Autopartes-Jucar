using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Sales
{
    public interface IOrderRepository
    {
        /* Crear */
        void CreateOrder(Order order);

        /* Listar */
        IEnumerable<Order> GetAllOrders(bool trackChanges);

        /* Un registro */
        Order GetOrder(Guid orderId, bool trackChanges);

        /* Eliminar */
        void DeleteOrder(Order order);
    }
}
