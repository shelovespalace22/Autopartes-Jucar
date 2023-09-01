using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record AutopartDto(int AutopartID, string Name, string Description, string WeightKgs, string HeightCm, string LengthCm, string VehicleZone, bool State, DateTime CreationDate, DateTime ModificationDate, int SubcategoryID);
} 
