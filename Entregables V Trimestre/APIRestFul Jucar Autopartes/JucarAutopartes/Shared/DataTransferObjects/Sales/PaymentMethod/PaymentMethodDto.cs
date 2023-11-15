using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.PaymentMethod
{
    public record PaymentMethodDto
    {
        public Guid PaymentMethodID { get; init; }
        public string PaymentMethodName { get; init; }
    }
}
