using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.CustomerAddress
{
    public record CustomerAddressForCreationDto
        (
            string Address,
            string AddressType,
            Guid NeighborhoodId
        );
}
