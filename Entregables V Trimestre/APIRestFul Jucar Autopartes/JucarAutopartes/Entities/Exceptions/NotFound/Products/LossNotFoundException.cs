using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Products
{
    public sealed class LossNotFoundException : NotFoundException
    {
        public LossNotFoundException(Guid lossId)
            :base($"The Loss with the ID: {lossId} doesn´t exist in the database.")
        {
            
        }
    }
}
