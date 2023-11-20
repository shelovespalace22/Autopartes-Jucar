using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Providers.ProviderPhone
{
    public record ProviderPhoneForUpdateDto
        (
            string? PhoneType,
            string? PhoneNumber
        );
}
