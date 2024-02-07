using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Products;
using Entities.Models.Products;
using Microsoft.EntityFrameworkCore;

namespace Repository.Products
{
    public class AutopartRepository : RepositoryBase<Autopart>, IAutopartRepository
    {
        public AutopartRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        /* Crear una Autoparte */
        public void CreateAutopartForSubcategory(Guid subcategoryId, Autopart autopart)
        {
            autopart.SubcategoryId = subcategoryId;

            Create(autopart);
        }

        /* Obteniendo todas las Autopartes en general */
        public async Task<IEnumerable<Autopart>> GetAllAutopartsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();

        /* Obteniendo Autoparte por su Id */
        public async Task<Autopart> GetAutopartByIdAsync(Guid autopartId, bool trackChanges) =>
            await FindByCondition(a => a.AutopartID.Equals(autopartId), trackChanges)
            .SingleOrDefaultAsync();

        /* Obtener todas las Autopartes de una Subcategoria */
        public async Task<IEnumerable<Autopart>> GetAutopartsAsync(Guid subcategoryId, bool trackChanges) =>
            await FindByCondition(a => a.SubcategoryId.Equals(subcategoryId), trackChanges)
            .OrderBy(a => a.Name)
            .ToListAsync();

        /* Obteniendo una Autoparte especifica de la Subcategoria */
        public async Task<Autopart> GetAutopartBySubcategoryAsync(Guid subcategoryId, Guid id, bool trackChanges) =>
            await FindByCondition(a => a.SubcategoryId.Equals(subcategoryId) && a.AutopartID.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        /* Obtener una colección de Autopartes de una Subcategoría*/
        public async Task<IEnumerable<Autopart>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.AutopartID), trackChanges)
            .ToListAsync();

        /* Eliminar una Autoparts */
        public void DeleteAutopart(Autopart autopart) => Delete(autopart);





        /* Actualizar Iventario */
        public void UpdateAutopartInventory(Autopart autopart)
        {
            Update(autopart);
        }
    }
}
