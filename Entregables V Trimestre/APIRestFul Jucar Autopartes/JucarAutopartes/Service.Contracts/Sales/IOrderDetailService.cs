using Shared.DataTransferObjects.Providers.ProviderPhone;
using Shared.DataTransferObjects.Sales.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Sales
{
    public interface IOrderDetailService
    {
        /* Listar */
        Task<IEnumerable<OrderDetailDto>> GetDetailsForOrderAsync(Guid orderId, bool trackChanges);
    }
}
