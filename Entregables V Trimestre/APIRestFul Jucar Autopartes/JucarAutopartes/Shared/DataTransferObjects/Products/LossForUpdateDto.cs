using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public record LossForUpdateDto(int AmountLoss, string? Responsible, string? Reason, DateTime LossDate);
}
