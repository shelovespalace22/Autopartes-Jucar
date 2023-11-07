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
    public record LossDto
    {
        public Guid LossID { get; init; }
        public int AmountLoss { get; init; }
        public string? Responsible { get; init; }
        public string? Reason { get; init; }
        public DateTime LossDate { get; init; }
        public DateTime CreationDate { get; init ; }
        public DateTime ModificationDate { get; init; }
        public Guid AutopartId { get; init; }
    }
}
