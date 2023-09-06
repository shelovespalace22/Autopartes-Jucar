using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record AutopartDto
    {
        public Guid AutopartID { get; init; }
        public string? Name { get; init; }
        public string? Description { get; init; }
        public string? WeightKgs { get; init; }
        public string? HeightCm { get; init; }
        public string? LengthCm { get; init; }
        public string? VehicleZone { get; init; }
        public bool State { get; init; }
        public DateTime CreationDate { get; init; }
        public DateTime ModificationDate { get; init; }
    }
} 
