using Entities.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Sales
{
    public interface IOrderDetailRepository
    {
        /* Listar */
        IEnumerable<OrderDetail> GetOrderDetails(Guid orderId, bool trackChanges);
    }
}
