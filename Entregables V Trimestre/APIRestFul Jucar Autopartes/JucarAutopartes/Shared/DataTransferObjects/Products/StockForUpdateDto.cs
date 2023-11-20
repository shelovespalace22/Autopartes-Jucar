using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public record StockForUpdateDto(int QuantityAvailable, int InitialStock, int ReorderPoint, int MinimumInventory, int MaximumInventory);
}
