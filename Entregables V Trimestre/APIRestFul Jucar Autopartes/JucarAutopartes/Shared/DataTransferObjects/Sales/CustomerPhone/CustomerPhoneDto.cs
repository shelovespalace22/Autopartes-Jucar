using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.CustomerPhone
{
    public record CustomerPhoneDto
    {
        public Guid CustomerPhoneID { get; init; }
        public string PhoneType { get; init; }
        public string PhoneNumber { get; init; }
        public Guid CustomerId { get; init; }
    }
}
