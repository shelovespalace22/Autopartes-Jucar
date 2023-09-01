﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ISubcategoryService
    {
        IEnumerable<SubcategoryDto> GetAllSubcategories(bool trackChanges);
    }
}
