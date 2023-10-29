using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Products
{
    public interface IRawMaterialService
    {
        /* Obtener todas las Materias Primas */
        IEnumerable<RawMaterialDto> GetAllRawMaterials(bool trackChanges);

        /* Obtener una Materia Prima */
        RawMaterialDto GetRawMaterial(Guid rawMaterialId, bool trackChanges);

        /* Crear una Materia Prima */
        RawMaterialDto CreateRawMaterial(RawMaterialForCreationDto rawMaterial);

        /* Obtener una colección de Materias Primas */
        IEnumerable<RawMaterialDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        /* Crear una colección de Materias Primas */
        (IEnumerable<RawMaterialDto> rawMaterials, string ids) CreateRawMaterialCollection
            (IEnumerable<RawMaterialForCreationDto> rawMaterialCollection);

        /* Eliminar una Materia Prima */
        void DeleteRawMaterial(Guid rawMaterialId, bool trackChanges);

        /* Actualizar una Materia Prima */
        void UpdateRawMaterial(Guid rawMaterialId, RawMaterialForUpdateDto rawMaterialForUpdate, bool trackChanges);
    }
}
