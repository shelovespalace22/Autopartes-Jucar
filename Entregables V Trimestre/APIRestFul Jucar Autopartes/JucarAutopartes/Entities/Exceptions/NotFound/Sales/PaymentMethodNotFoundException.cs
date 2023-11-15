using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Sales
{
    public sealed class PaymentMethodNotFoundException : NotFoundException
    {
        public PaymentMethodNotFoundException(Guid paymentMethodId)
            :base($"The Payment Method with ID: {paymentMethodId} doesn´t exist in the database.")
        {
            
        }
    }
}
