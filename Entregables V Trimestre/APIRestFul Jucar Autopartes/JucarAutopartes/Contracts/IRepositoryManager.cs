using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository Category { get; }
        ISubcategoryRepository Subcategory { get; }
        IAutopartRepository Autopart { get; }
        IFactoryRepository Factory { get; }

        void Save();

    }
}
