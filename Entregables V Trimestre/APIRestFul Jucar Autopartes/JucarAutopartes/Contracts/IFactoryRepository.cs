using Entities.Models.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IFactoryRepository
    {
        IEnumerable<Factory> GetAllFactories(bool trakChanges);

    }
}
