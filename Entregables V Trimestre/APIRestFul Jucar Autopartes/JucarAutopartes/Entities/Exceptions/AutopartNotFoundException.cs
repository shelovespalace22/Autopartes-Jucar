using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class AutopartNotFoundException : NotFoundException
    {
        public AutopartNotFoundException(Guid autopartId)
            :base($"The Autopart with ID: {autopartId} doesn´t exist in the database.")
        {
            
        }
    }
}
