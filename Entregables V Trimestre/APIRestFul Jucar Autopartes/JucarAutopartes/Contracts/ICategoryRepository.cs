﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;

namespace Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);

        Category GetCategory(Guid categoryId, bool trackChanges);

        /* Crear Categoria */
        void CreateCategory(Category category);
    }
}
