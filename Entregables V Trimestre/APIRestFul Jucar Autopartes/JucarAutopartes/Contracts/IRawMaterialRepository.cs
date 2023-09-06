using Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRawMaterialRepository
    {
        /* Crear un RawMaterila */
        void CreateRawMaterial(RawMaterial rawMaterial);
    }
}
