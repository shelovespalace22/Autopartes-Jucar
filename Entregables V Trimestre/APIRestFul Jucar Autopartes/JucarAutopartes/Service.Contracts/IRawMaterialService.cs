﻿using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IRawMaterialService
    {
        /* Crear un RawMaterial */
        RawMaterialDto CreateRawMaterial(RawMaterialForCreationDto rawMaterial);
    }
}
