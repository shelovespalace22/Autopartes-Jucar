using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.Contribution
{
    public record ContributionDto
    {
        public Guid OrderId { get; init; }
        public Guid ContributionID { get; init; }
        public Guid PaymentMethodId { get; init; }
        public string? PaymentMethodName { get; init; }
        public decimal AmountPaid { get; init; }
        public DateTime ContributionDate { get; init; }
    }
}
