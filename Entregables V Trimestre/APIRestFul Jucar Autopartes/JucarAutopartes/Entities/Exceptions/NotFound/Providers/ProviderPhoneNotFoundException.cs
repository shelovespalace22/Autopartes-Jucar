using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Providers
{
    public sealed class ProviderPhoneNotFoundException : NotFoundException
    {
        public ProviderPhoneNotFoundException(Guid providerPhoneId)
            : base($"The Provider Phone with ID: {providerPhoneId} doesn´t exist in the database.")
        {
            
        }
    }
}
