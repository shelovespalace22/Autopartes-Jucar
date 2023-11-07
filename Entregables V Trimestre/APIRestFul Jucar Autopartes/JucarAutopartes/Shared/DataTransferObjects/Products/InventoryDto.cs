using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public record InventoryDto
    {
        public Guid InventoryID { get; init; }

        public int QuantityAvailable { get; init; } 

        public DateTime CreationDate { get; init; }

        public DateTime UltimateModificationDate { get; init; }

        public Guid AutopartId { get; init; }
    }
}
