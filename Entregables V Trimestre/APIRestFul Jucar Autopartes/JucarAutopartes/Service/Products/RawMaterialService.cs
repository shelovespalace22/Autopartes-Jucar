using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Exceptions.BadRequest.Products;
using Entities.Exceptions.NotFound.Products;
using Entities.Models.Products;
using Service.Contracts.Products;
using Shared.DataTransferObjects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Products
{
    public class RawMaterialService : IRawMaterialService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RawMaterialService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Obtener todas las Materias Primas */
        public async Task<IEnumerable<RawMaterialDto>> GetAllRawMaterialsAsync(bool trackChanges)
        {
            var rawMaterials = await _repository.RawMaterial.GetAllRawMaterialsAsync(trackChanges);

            var rawMaterialsDto = _mapper.Map<IEnumerable<RawMaterialDto>>(rawMaterials);

            return rawMaterialsDto;
        }

        /* Obtener una Materia Prima */
        public async Task<RawMaterialDto> GetRawMaterialAsync(Guid id, bool trackChanges)
        {
            var rawMaterial = await GetRawMaterialAndCheckIfItExists(id, trackChanges);

            var rawMaterialDto = _mapper.Map<RawMaterialDto>(rawMaterial);

            return rawMaterialDto;
        }

        /* Crear una Materia Prima */
        public async Task<RawMaterialDto> CreateRawMaterialAsync(RawMaterialForCreationDto rawMaterial)
        {
            var rawMaterialEntity = _mapper.Map<RawMaterial>(rawMaterial);

            _repository.RawMaterial.CreateRawMaterial(rawMaterialEntity);

            await _repository.SaveAsync();

            var rawMaterialToReturn = _mapper.Map<RawMaterialDto>(rawMaterialEntity);

            return rawMaterialToReturn;
        }

        /* Obtener una colección de Materias Primas */
        public async Task<IEnumerable<RawMaterialDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var rawMaterialEntities = await _repository.RawMaterial.GetByIdsAsync(ids, trackChanges);

            if (ids.Count() != rawMaterialEntities.Count())
                throw new CollectionByIdsBadRequestException();

            var rawMaterialsToReturn = _mapper.Map<IEnumerable<RawMaterialDto>>(rawMaterialEntities);

            return rawMaterialsToReturn;
        }

        /* Crear una colección de Materias Primas */
        public async Task<(IEnumerable<RawMaterialDto> rawMaterials, string ids)> CreateRawMaterialCollectionAsync(IEnumerable<RawMaterialForCreationDto> rawMaterialCollection)
        {
            if (rawMaterialCollection is null)
                throw new RawMaterialCollectionBadRequest();

            var rawMaterialEntities = _mapper.Map<IEnumerable<RawMaterial>>(rawMaterialCollection);

            foreach (var rawMaterial in rawMaterialEntities)
            {
                _repository.RawMaterial.CreateRawMaterial(rawMaterial);
            }

            await _repository.SaveAsync();

            var rawMaterialCollectionToReturn = _mapper.Map<IEnumerable<RawMaterialDto>>(rawMaterialEntities);

            var ids = string.Join(",", rawMaterialCollectionToReturn.Select(r => r.RawMaterialId));

            return (rawMaterials: rawMaterialCollectionToReturn, ids: ids);
        }

        /* Eliminar una Materia Prima */
        public async Task DeleteRawMaterialAsync(Guid rawMaterialId, bool trackChanges)
        {
            var rawMaterial = await GetRawMaterialAndCheckIfItExists(rawMaterialId, trackChanges);

            _repository.RawMaterial.DeleteRawMaterial(rawMaterial);

            await _repository.SaveAsync();
        }

        /* Actualizar una Materia Prima */
        public async Task UpdateRawMaterialAsync(Guid rawMaterialId, RawMaterialForUpdateDto rawMaterialForUpdate, bool trackChanges)
        {
            var rawMaterialEntity = await GetRawMaterialAndCheckIfItExists(rawMaterialId, trackChanges);

            _mapper.Map(rawMaterialForUpdate, rawMaterialEntity);

            rawMaterialEntity.setModificationDate();

            await _repository.SaveAsync();
        }






        /* <----- Métodos Privados -----> */

        private async Task<RawMaterial> GetRawMaterialAndCheckIfItExists(Guid id, bool trackChanges)
        {
            var rawMaterial = await _repository.RawMaterial.GetRawMaterialAsync(id, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(id);

            return rawMaterial;
        }
    }
}
