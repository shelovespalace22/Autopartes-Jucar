using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Providers.ProviderPhone
{
    public record ProviderPhoneForCreationDto
        (
            string PhoneType,
            string PhoneNumber
        );
}
