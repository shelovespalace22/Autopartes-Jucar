using Contracts.Sales;
using Entities.Models.Sales;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sales
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Crear */
        public void CreateOrder(Guid customerId, Order order)
        {
            order.CustomerId = customerId;

            Create(order);
        }

        /* Eliminar */
        public void DeleteOrder(Order order) => Delete(order);

        /* Listar */
        public async Task<IEnumerable<Order>> GetAllOrdersAsync(Guid customerId, bool trackChanges) =>
            await FindByCondition(o => o.CustomerId.Equals(customerId), trackChanges)
            .OrderBy(o => o.OrderDate)
            .ToListAsync();

        /* Un registro */
        public async Task<Order> GetOrderByCustomerAsync(Guid customerId, Guid orderId, bool trackChanges) =>
            await FindByCondition(o => o.OrderID.Equals(orderId) && o.OrderID.Equals(orderId), trackChanges)
            .SingleOrDefaultAsync();


        /* Obtener una instancia */

        public async Task<Order> GetOrderByIdAsync(Guid orderId, bool trackChanges) =>
            await FindByCondition(o => o.OrderID.Equals(orderId), trackChanges)
            .SingleOrDefaultAsync();
    }
}
