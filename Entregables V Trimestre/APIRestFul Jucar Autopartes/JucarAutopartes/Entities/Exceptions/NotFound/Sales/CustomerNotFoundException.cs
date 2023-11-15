using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Sales
{
    public sealed class CustomerNotFoundException : NotFoundException
    {
        public CustomerNotFoundException(Guid customerId)
            :base($"The Customer with ID: {customerId} doesn´t exist in the database.")
        {
            
        }
    }
}
