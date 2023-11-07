using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public record MovementForCreationDto(int Quantity, string? MovementType, DateTime MovementDate);
}
