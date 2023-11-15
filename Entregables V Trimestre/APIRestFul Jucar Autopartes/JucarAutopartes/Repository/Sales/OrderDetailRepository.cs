using Contracts.Sales;
using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sales
{
    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Listar */
        public IEnumerable<OrderDetail> GetOrderDetails(Guid orderId, bool trackChanges) =>
            FindByCondition(d => d.OrderId.Equals(orderId), trackChanges)
            .OrderBy(d => d.SubtotalValue)
            .ToList();
    }
}
