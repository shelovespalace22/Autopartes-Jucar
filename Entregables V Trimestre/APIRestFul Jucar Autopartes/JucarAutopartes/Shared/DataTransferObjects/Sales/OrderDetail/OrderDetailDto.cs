using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.OrderDetail
{
    public record OrderDetailDto
    {
        public Guid OrderDetailID { get; init; }
        public Guid AutopartId { get; init; }
        public string Quantity { get; init; }
        public decimal UnitValue { get; init; }
        public decimal SubtotalValue { get; init; }
        public Guid OrderId { get; init; }
    }
}
