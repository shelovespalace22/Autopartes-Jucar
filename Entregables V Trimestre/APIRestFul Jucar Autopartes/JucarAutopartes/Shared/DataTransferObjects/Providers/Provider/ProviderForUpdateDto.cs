using Shared.DataTransferObjects.Providers.ProviderAddress;
using Shared.DataTransferObjects.Providers.ProviderPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Providers.Provider
{
    public record ProviderForUpdateDto(string IdentifierType,
        string IdentifierNumber,
        string Name,
        string EmailAddress,
        string ProductType
        );
}
