using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Providers.ProviderAddress
{
    public record ProviderAddressDto
    {
        public Guid ProviderAddressID { get; init; }
        public string? Address { get; init; }
        public string? AddressType { get; init; }
        public Guid NeighborhoodId { get; init; }
        public string? NeighborhoodName { get; init; }
        public Guid ProviderId { get; init; }
    }
}
