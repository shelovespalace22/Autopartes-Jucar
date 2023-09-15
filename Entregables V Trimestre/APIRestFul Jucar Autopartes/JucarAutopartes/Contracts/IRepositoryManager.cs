using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Contracts.Factories;
using Contracts.Products;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository Category { get; }
        ISubcategoryRepository Subcategory { get; }
        IAutopartRepository Autopart { get; }
        IRawMaterialRepository RawMaterial { get; }
        IAutopartMaterialRepository AutopartMaterial { get; }
        

        void Save();

    }
}
