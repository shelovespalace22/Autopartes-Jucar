using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public record PriceHistoryDto
    {
        public Guid PriceHistoryID { get; init; }
        public double Value { get; init; }
        public bool State { get; init; }
        public DateTime CreationDate { get; init; }
        public DateTime ModificationDate { get; init; }
        public Guid AutopartId { get; init; }
    }
}
