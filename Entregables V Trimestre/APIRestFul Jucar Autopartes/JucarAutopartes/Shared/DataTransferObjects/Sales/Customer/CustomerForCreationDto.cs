using Shared.DataTransferObjects.Sales.CustomerAddress;
using Shared.DataTransferObjects.Sales.CustomerPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.Customer
{
    public record CustomerForCreationDto
        (
            string IdentifierType,
            string IdentifierNumber,
            string Name,
            string Email,
            ICollection<CustomerAddressForCreationDto>? CustomerAddresses,
            ICollection<CustomerPhoneForCreationDto>? CustomerPhones
        );
}
