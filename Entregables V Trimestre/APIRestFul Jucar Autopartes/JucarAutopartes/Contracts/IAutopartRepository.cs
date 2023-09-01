﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;

namespace Contracts
{
    public interface IAutopartRepository
    {
        IEnumerable<Autopart> GetAllAutoparts(bool trackChanges);

        Autopart GetAutopart(int autopartId, bool trackChanges);
    }
}