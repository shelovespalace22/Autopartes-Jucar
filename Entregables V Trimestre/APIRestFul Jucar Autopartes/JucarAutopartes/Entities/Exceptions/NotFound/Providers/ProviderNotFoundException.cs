using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Providers
{
    public sealed class ProviderNotFoundException : NotFoundException
    {
        public ProviderNotFoundException(Guid providerId)
            :base($"The Provider with ID: {providerId} doesn´t exist in the database.")
        {
            
        }
    }
}
