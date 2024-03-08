using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Ubications
{
    public sealed class MunicipalityNotFoundException : NotFoundException
    {
        public MunicipalityNotFoundException(Guid municipalityId)
            :base($"The Municipality with ID: {municipalityId} doesn´t exist in the database.")
        {
            
        }
    }
}
