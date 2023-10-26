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

        /* Obtener todos los Materiales de una Autoparte */
        IEnumerable<AutopartMaterial> GetMaterials(Guid autopartId, bool trackChanges);
    }
}
