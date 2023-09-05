using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class SubcategoryNotFoundException : NotFoundException
    {
        public SubcategoryNotFoundException(Guid subcategoryId)
            :base($"The Subcategory with ID: {subcategoryId} doesn´t exist in the database.")
        {
            
        }
    }
}
