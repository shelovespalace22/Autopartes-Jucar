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
        void CreateOrder(Guid customerId ,Order order);

        /* Listar */
        Task<IEnumerable<Order>> GetAllOrdersAsync(Guid customerId, bool trackChanges);

        /* Un registro */
        Task<Order> GetOrderByCustomerAsync(Guid customerId, Guid orderId, bool trackChanges);

        /* Eliminar */
        void DeleteOrder(Order order);


        /* Obtener Instancia */
        Task<Order> GetOrderByIdAsync(Guid orderId, bool trackChanges);
    }
}
