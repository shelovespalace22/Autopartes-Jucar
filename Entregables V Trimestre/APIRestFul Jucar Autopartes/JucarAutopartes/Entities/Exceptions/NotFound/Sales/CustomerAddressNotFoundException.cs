using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Sales
{
    public sealed class CustomerAddressNotFoundException : NotFoundException
    {
        public CustomerAddressNotFoundException(Guid customerAddressId)
            :base($"The Customer Address with ID: {customerAddressId} doesn´t exist in the database.")
        {
            
        }
    }
}
