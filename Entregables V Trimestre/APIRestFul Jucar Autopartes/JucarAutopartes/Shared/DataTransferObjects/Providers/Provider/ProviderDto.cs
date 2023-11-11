using Shared.DataTransferObjects.Providers.ProviderAddress;
using Shared.DataTransferObjects.Providers.ProviderPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Providers.Provider
{
    public record ProviderDto
    {
        public Guid ProviderID { get; init; }
        public string IdentifierType { get; init; }
        public string IdentifierNumber { get; init; }
        public string Name { get; init; }
        public string EmailAddress { get; init; }
        public string ProductType { get; init; }
        public ICollection<ProviderAddressDto>? ProviderAddresses { get; init; }
        public ICollection<ProviderPhoneDto>? ProviderPhones { get; init; }
    }
}
