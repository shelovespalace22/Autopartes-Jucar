using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Products
{
    public interface IAutopartMaterialService
    {
        /* Obtener todos los materiales */
        IEnumerable<AutopartMaterialDto> GetAllMaterials(bool trackChanges);
    }
}
