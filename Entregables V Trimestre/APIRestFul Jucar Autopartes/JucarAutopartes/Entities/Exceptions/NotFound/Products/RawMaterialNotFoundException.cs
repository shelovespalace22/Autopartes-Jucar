using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.NotFound.Products
{
    public sealed class RawMaterialNotFoundException : NotFoundException
    {
        public RawMaterialNotFoundException(Guid rawMaterialId)
            : base($"The Raw Material with ID: {rawMaterialId} doesn´t exist in the database")
        {

        }
    }
}
