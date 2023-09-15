using Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Products
{
    public interface IAutopartMaterialRepository
    {
        /* Obtener todos los Materiales*/
        IEnumerable<AutopartMaterial> GetAllMaterials(bool trackChanges);
    }
}
