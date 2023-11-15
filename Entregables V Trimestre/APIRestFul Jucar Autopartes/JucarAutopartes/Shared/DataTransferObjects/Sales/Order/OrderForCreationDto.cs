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
        (
            DateTime OrderDate,
            Guid CustomerId,
            decimal? IVA,
            decimal? Total,
            string PaymentStatus,
            string ShippingAddress,
            string ShippingStatus,
            string? Observation,
            ICollection<OrderDetailForCreationDto> OrderDetails,
            ICollection<ContributionForCreationDto>? Contributions
        );
}
