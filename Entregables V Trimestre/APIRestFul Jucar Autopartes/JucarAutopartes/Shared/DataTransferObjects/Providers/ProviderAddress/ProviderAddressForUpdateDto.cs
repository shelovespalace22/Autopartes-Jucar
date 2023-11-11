using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Providers.ProviderAddress
{
    public record ProviderAddressForUpdateDto
        (
            string? Address,
            string? AddressType,
            Guid NeighborhoodId
        );

}
