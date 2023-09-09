﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products
{
    public record AutopartForUpdateDto(string Name, string Description, string WeightKgs, string HeightCm, string LengthCm, string VehicleZone);
}