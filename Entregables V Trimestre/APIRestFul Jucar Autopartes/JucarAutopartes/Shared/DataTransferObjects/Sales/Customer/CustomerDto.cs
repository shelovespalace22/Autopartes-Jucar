using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects.Sales.CustomerAddress;
using Shared.DataTransferObjects.Sales.CustomerPhone;

namespace Shared.DataTransferObjects.Sales.Customer
{
    public record CustomerDto
    {
        public Guid CustomerID { get; init; }
        public string IdentifierType { get; init; }
        public string IdentifierNumber { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public ICollection<CustomerAddressDto>? CustomerAddresses { get; init; }
        public ICollection<CustomerPhoneDto>? CustomerPhones { get; init; }
    }
}
