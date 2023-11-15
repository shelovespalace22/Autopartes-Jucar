using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Sales
{
    public sealed class OrderDetailNotFoundException : NotFoundException
    {
        public OrderDetailNotFoundException(Guid orderDetailId)
            :base($"The Order Detail with ID: {orderDetailId} doesn´t exist in the database.")
        {
            
        }
    }
}
