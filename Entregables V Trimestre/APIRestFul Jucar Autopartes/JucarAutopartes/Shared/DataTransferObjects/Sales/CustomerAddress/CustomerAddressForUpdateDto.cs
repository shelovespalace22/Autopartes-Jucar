using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.CustomerAddress
{
    public record CustomerAddressForUpdateDto
        (
            string Address,
            string AddressType,
            Guid NeighborhoodId
        );
}
