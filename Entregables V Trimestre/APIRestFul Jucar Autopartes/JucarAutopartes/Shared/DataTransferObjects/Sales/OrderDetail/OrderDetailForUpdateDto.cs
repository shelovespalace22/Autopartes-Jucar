using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.OrderDetail
{
    public record OrderDetailForUpdateDto
    (
        Guid AutopartId,
        string Quantity,
        decimal UnitValue,
        decimal SubtotalValue
    );
}
