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
        /* Obteniendo todas las Autopartes en general */
        IEnumerable<Autopart> GetAllAutoparts(bool trackChanges);

        /* Obteniendo Autoparte por su Id */
        Autopart GetAutopartById(Guid autopartId, bool trackChanges);

        /* Obtener todas las Autopartes de una Subcategoria */
        IEnumerable<Autopart> GetAutoparts(Guid autopartId, bool trackChanges);

        /* Obtener una Autopartes especifica de una Subcategoria */
        Autopart GetAutopartBySubcategory(Guid subcategoryId, Guid id, bool trackChanges);

        /* Crear una Autoparte */
        void CreateAutopartForSubcategory(Guid subcategoryId, Autopart autopart);
    }
}
