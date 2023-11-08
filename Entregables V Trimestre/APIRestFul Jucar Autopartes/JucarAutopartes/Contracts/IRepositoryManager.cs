using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Products;

namespace Contracts
{
    public interface IRepositoryManager
    {

        /* Productos */
        ICategoryRepository Category { get; }
        ISubcategoryRepository Subcategory { get; }
        IAutopartRepository Autopart { get; }
        IRawMaterialRepository RawMaterial { get; }
        IStockRepository Stock { get; }
        ILossRepository Loss { get; }
        IMovementRepository Movement { get; }

        void Save();

    }
}
