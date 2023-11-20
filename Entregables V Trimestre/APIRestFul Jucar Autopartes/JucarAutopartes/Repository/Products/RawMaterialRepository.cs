using Contracts.Products;
using Entities.Models.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Products
{
    public class RawMaterialRepository : RepositoryBase<RawMaterial>, IRawMaterialRepository
    {
        public RawMaterialRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        /* Obtener todas las Materias Primas */

        public IEnumerable<RawMaterial> GetAllRawMaterials(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(r => r.Name)
            .ToList();

        /* Obtener una Materia Prima */

        public RawMaterial GetRawMaterial(Guid rawMaterialId, bool trackChanges) =>
            FindByCondition(r => r.RawMaterialID.Equals(rawMaterialId), trackChanges)
            .Include(r => r.Stock)
            .SingleOrDefault();

        /* Crear Materia Prima*/

        public void CreateRawMaterial(RawMaterial rawMaterial) => Create(rawMaterial);

        /* Obtener colección de Materias Primas */

        public IEnumerable<RawMaterial> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.RawMaterialID), trackChanges)
            .ToList();

        /* Eliminar una Materia Prima */
        public void DeleteRawMaterial(RawMaterial rawMaterial) => Delete(rawMaterial);
    }
}
