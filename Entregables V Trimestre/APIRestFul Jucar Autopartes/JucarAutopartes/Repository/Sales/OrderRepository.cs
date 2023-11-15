using Contracts.Sales;
using Entities.Models.Sales;
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
        public void CreateOrder(Order order) => Create(order);

        /* Eliminar */
        public void DeleteOrder(Order order) => Delete(order);

        /* Listar */
        public IEnumerable<Order> GetAllOrders(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(o => o.OrderDate)
            .ToList();

        /* Un registro */
        public Order GetOrder(Guid orderId, bool trackChanges) =>
            FindByCondition(o => o.OrderID.Equals(orderId), trackChanges)
            .SingleOrDefault();
    }
}
