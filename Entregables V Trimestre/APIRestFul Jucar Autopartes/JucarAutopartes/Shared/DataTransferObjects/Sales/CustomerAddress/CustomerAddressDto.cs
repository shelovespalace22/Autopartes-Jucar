using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.CustomerAddress
{
    public record CustomerAddressDto
    {
        public Guid CustomerAddressID { get; init; }
        public string Address { get; init; }
        public string AddressType { get; init; }
        public Guid NeighborhoodId { get; init; }
        public Guid CustomerId { get; init; }
    }
}
