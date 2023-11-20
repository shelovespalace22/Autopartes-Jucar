using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public class MovementDto
    {
        public Guid MovementID { get; init; }
        public int Quantity { get; init; }
        public string? MovementType { get; init; }
        public DateTime MovementDate { get; init; }
        public DateTime CreationDate { get; init; }
        public DateTime ModificationDate { get; init; }
        public Guid RawMaterialId { get; init; }
    }
}
