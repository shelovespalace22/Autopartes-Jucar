using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public class AutopartMaterialDto
    {
        public Guid AutopartMaterialID { get; init; }
        public Guid AutopartId { get; init; }
        public Guid RawMaterialId { get; init; }
        public DateTime CreationDate { get; init; }
        public DateTime ModificationDate { get; init; }
        
    }
   
}
