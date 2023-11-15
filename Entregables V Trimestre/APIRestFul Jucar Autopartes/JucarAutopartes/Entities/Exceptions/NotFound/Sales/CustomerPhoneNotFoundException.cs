using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Sales
{
    public sealed class CustomerPhoneNotFoundException : NotFoundException
    {
        public CustomerPhoneNotFoundException(Guid customerPhoneId)
            :base($"The Customer Phone with ID: {customerPhoneId} doesn´t exist in the database.")
        {
            
        }
    }
}
