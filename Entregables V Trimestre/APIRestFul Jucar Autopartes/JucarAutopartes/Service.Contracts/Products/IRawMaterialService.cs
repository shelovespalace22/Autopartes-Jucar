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
        Task<IEnumerable<RawMaterialDto>> GetAllRawMaterialsAsync(bool trackChanges);

        /* Obtener una Materia Prima */
        Task<RawMaterialDto> GetRawMaterialAsync(Guid rawMaterialId, bool trackChanges);

        /* Crear una Materia Prima */
        Task<RawMaterialDto> CreateRawMaterialAsync(RawMaterialForCreationDto rawMaterial);

        /* Obtener una colección de Materias Primas */
        Task<IEnumerable<RawMaterialDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);

        /* Crear una colección de Materias Primas */
        Task<(IEnumerable<RawMaterialDto> rawMaterials, string ids)> CreateRawMaterialCollectionAsync
            (IEnumerable<RawMaterialForCreationDto> rawMaterialCollection);

        /* Eliminar una Materia Prima */
        Task DeleteRawMaterialAsync(Guid rawMaterialId, bool trackChanges);

        /* Actualizar una Materia Prima */
        Task UpdateRawMaterialAsync(Guid rawMaterialId, RawMaterialForUpdateDto rawMaterialForUpdate, bool trackChanges);
    }
}
