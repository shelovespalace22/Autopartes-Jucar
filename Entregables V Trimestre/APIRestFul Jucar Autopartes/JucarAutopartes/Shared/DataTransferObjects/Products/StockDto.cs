using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public record StockDto
    {
  
        public Guid StockID { get; init; }
        public int QuantityAvailable { get; init; }
        public int InitialStock { get; init; }
        public int ReorderPoint { get; init; }
        public int MinimumInventory { get; init; }
        public int MaximumInventory { get; init; }
        public DateTime CreationDate { get; init; }
        public DateTime ModificationDate { get; init; }
        public Guid RawMaterialId { get; init; }
    }
}
