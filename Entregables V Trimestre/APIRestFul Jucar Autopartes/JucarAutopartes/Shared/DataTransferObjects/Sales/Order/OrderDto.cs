using Shared.DataTransferObjects.Sales.Contribution;
using Shared.DataTransferObjects.Sales.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.Order
{
    public record OrderDto
    {
        public Guid OrderID { get; init; }
        public DateTime OrderDate { get; init; }
        public Guid CustomerId { get; init; }
        public decimal? Total { get; init; }
        public string? PaymentStatus { get; init; }
        public string? ShippingAddress { get; init; }
        public string? ShippingStatus { get; init; }
        public string? Observation { get; init; }
        public ICollection<OrderDetailDto>? OrderDetails { get; init; }
        public ICollection<ContributionDto>? Contributions { get; init; }
    }
}
