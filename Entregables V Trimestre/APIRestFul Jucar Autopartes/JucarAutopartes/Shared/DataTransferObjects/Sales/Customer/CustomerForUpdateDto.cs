using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.Customer
{
    public record CustomerForUpdateDto
        (
            string IdentifierType,
            string IdentifierNumber,
            string Name,
            string Email
        );
}
