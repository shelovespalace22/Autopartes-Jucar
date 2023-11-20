using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Providers
{
    public sealed class ProviderAddressNotFoundException : NotFoundException
    {
        public ProviderAddressNotFoundException(Guid providerAddressId)
            :base($"The Provider Address with ID: {providerAddressId} doesn´t exist in the database.")
        {
            
        }
    }
}
