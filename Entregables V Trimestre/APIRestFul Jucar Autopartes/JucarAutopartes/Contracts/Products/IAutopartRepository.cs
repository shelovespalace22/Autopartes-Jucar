﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;

namespace Contracts.Products
{
    public interface IAutopartRepository
    {
        /* Crear una Autoparte */
        void CreateAutopartForSubcategory(Guid subcategoryId, Autopart autopart);

        /* Obteniendo todas las Autopartes en general */
        Task<IEnumerable<Autopart>> GetAllAutopartsAsync(bool trackChanges);

        /* Obteniendo Autoparte por su Id */
        Task<Autopart> GetAutopartByIdAsync(Guid autopartId, bool trackChanges);

        /* Obtener todas las Autopartes de una Subcategoria */
        Task<IEnumerable<Autopart>> GetAutopartsAsync(Guid autopartId, bool trackChanges);

        /* Obtener una Autopartes especifica de una Subcategoria */
        Task<Autopart> GetAutopartBySubcategoryAsync(Guid subcategoryId, Guid id, bool trackChanges);

        /* Obtener una colección de Autopartes de una Subcategoría*/
        Task<IEnumerable<Autopart>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);

        /* Eliminar una Autoparte */
        void DeleteAutopart(Autopart autopart);





        /* Actualizar Inventario */
        void UpdateAutopartInventory(Autopart autopart);
    }
}
