using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Providers.ProviderPhone
{
    public record ProviderPhoneDto
    {
        public Guid ProviderPhoneID { get; init; }
        public string? PhoneType { get; init; }
        public string? PhoneNumber { get; init; }
        public Guid ProviderId { get; init; }
    }
}
