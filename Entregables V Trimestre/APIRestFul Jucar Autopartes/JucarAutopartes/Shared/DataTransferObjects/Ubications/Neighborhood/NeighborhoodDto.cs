using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Ubications.Neighborhood
{
    public record NeighborhoodDto
    {
        public Guid NeighborhoodID { get; init; }
        public string? Name { get; init; }
    }
}
