using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record SubcategoryDto(int SubcategoryID, string Name, bool State, DateTime CreationDate, DateTime ModificationDate, int CategoryID);
}
