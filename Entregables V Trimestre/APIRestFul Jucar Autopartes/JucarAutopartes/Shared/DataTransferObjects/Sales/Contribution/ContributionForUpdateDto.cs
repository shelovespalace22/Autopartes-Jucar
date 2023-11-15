using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.Contribution
{
    public record ContributionForUpdateDto
    (
        Guid PaymentMethodId,
        decimal AmountPaid,
        DateTime ContributionDate
    );
}
