using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Products
{
    public sealed class MovementNotFoundException : NotFoundException
    {
        public MovementNotFoundException(Guid movementId)
            :base($"The Movement with ID: {movementId} doesn´t exist in the database.")
        {
            
        }
    }
}
