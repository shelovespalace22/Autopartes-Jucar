using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public record RawMaterialForUpdateDto(string Name, string Type, DateTime ModificationDate)
    {
        public RawMaterialForUpdateDto(string name, string type)
            : this(name, type, DateTime.UtcNow)
        {

        }

    }
}
