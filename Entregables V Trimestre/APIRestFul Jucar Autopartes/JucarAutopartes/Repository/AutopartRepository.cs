using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models.Products;

namespace Repository
{
    public class AutopartRepository : RepositoryBase<Autopart>, IAutopartRepository
    {
        public AutopartRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        /* Obteniendo todas las Autopartes en general */
        public IEnumerable<Autopart> GetAllAutoparts(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        /* Obteniendo Autoparte por su Id */
        public Autopart GetAutopartById(Guid autopartId, bool trackChanges) =>
            FindByCondition(a => a.AutopartID.Equals(autopartId), trackChanges)
            .SingleOrDefault();

        /* Obtener todas las Autopartes de una Subcategoria */
        public IEnumerable<Autopart> GetAutoparts(Guid subcategoryId, bool trackChanges) =>
            FindByCondition(a => a.SubcategoryId.Equals(subcategoryId), trackChanges)
            .OrderBy(a => a.Name)
            .ToList();

        /* Obteniendo una Autopartes especifica de la Subcategoria */
        public Autopart GetAutopartBySubcategory(Guid subcategoryId, Guid id, bool trackChanges) =>
            FindByCondition(a => a.SubcategoryId.Equals(subcategoryId) && a.AutopartID.Equals(id), trackChanges)
            .SingleOrDefault();

        /* Crear una Autoparte */
        public void CreateAutopartForSubcategory(Guid subcategoryId, Autopart autopart)
        {
            autopart.SubcategoryId = subcategoryId;

            Create(autopart);
        }
    }
}
