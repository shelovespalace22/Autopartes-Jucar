using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.OrderDetail
{
    public record OrderDetailForCreationDto
    {
        public Guid AutopartId { get; init; }
        public int Quantity { get; init; }
        public decimal? UnitValue { get; set; }
        public decimal? SubtotalValue { get; set; }
    }

}
