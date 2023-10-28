//using Entities.Models.Products;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Contracts.Products
//{
//    public interface IRawMaterialRepository
//    {
//        /* Obtener todas las Materias Primas */
//        IEnumerable<RawMaterial> GetAllRawMaterials(bool trackChanges);

//        /* Obtener una Materia Prima */
//        RawMaterial GetRawMaterial(Guid rawMaterialId, bool trackChanges);

//        /* Crear Materia Prima */
//        void CreateRawMaterial(RawMaterial rawMaterial);

//        /* Obtener una colección de Materias Primas */
//        IEnumerable<RawMaterial> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

//        /* Eliminar una Materia Prima */
//        void DeleteRawMaterial(RawMaterial rawMaterial);

//    }
//}
