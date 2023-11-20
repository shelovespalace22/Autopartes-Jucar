using Shared.DataTransferObjects.Sales.Contribution;
using Shared.DataTransferObjects.Sales.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.Order
{
    public record OrderForCreationDto
    {
        public DateTime OrderDate { get; init; }
        public Guid CustomerId { get; init; }
        public decimal? Total { get; set; }
        public string? PaymentStatus { get; init; }
        public string? ShippingAddress { get; init; }
        public string? ShippingStatus { get; init; }
        public string? Observation { get; init; }
        public ICollection<OrderDetailForCreationDto>? OrderDetails { get; init; }
        public ICollection<ContributionForCreationDto>? Contributions { get; init; }
    }
}
