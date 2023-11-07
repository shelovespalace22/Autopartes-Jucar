using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public record AutopartForCreationDto(string Name, string Description, int Inventory, decimal Value, Guid RawMaterialId, IEnumerable<PriceHistorieForCreationDto>? PriceHistories);
}
