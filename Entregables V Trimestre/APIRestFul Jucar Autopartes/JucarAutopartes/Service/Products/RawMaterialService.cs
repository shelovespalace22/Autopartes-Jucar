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

        public IEnumerable<RawMaterialDto> GetAllRawMaterials(bool trackChanges)
        {
            var rawMaterials = _repository.RawMaterial.GetAllRawMaterials(trackChanges);

            var rawMaterialsDto = _mapper.Map<IEnumerable<RawMaterialDto>>(rawMaterials);

            return rawMaterialsDto;
        }

        /* Obtener una Materia Prima */

        public RawMaterialDto GetRawMaterial(Guid id, bool trackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(id, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(id);

            var rawMaterialDto = _mapper.Map<RawMaterialDto>(rawMaterial);

            return rawMaterialDto;
        }

        /* Crear una Materia Prima */

        public RawMaterialDto CreateRawMaterial(RawMaterialForCreationDto rawMaterial)
        {
            var rawMaterialEntity = _mapper.Map<RawMaterial>(rawMaterial);

            _repository.RawMaterial.CreateRawMaterial(rawMaterialEntity);

            _repository.Save();

            var rawMaterialToReturn = _mapper.Map<RawMaterialDto>(rawMaterialEntity);

            return rawMaterialToReturn;
        }

        /* Obtener una colección de Materias Primas */

        public IEnumerable<RawMaterialDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var rawMaterialEntities = _repository.RawMaterial.GetByIds(ids, trackChanges);

            if (ids.Count() != rawMaterialEntities.Count())
                throw new CollectionByIdsBadRequestException();

            var rawMaterialsToReturn = _mapper.Map<IEnumerable<RawMaterialDto>>(rawMaterialEntities);

            return rawMaterialsToReturn;
        }

        /* Crear una colección de Materias Primas */

        public (IEnumerable<RawMaterialDto> rawMaterials, string ids) CreateRawMaterialCollection(IEnumerable<RawMaterialForCreationDto> rawMaterialCollection)
        {
            if (rawMaterialCollection is null)
                throw new RawMaterialCollectionBadRequest();

            var rawMaterialEntities = _mapper.Map<IEnumerable<RawMaterial>>(rawMaterialCollection);

            foreach (var rawMaterial in rawMaterialEntities)
            {
                _repository.RawMaterial.CreateRawMaterial(rawMaterial);
            }

            _repository.Save();

            var rawMaterialCollectionToReturn = _mapper.Map<IEnumerable<RawMaterialDto>>(rawMaterialEntities);

            var ids = string.Join(",", rawMaterialCollectionToReturn.Select(r => r.RawMaterialId));

            return (rawMaterials: rawMaterialCollectionToReturn, ids: ids);
        }

        /* Eliminar una Materia Prima */

        public void DeleteRawMaterial(Guid rawMaterialId, bool trackChanges)
        {
            var rawMaterial = _repository.RawMaterial.GetRawMaterial(rawMaterialId, trackChanges);

            if (rawMaterial is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            _repository.RawMaterial.DeleteRawMaterial(rawMaterial);

            _repository.Save();
        }

        /* Actualizar una Materia Prima */

        public void UpdateRawMaterial(Guid rawMaterialId, RawMaterialForUpdateDto rawMaterialForUpdate, bool trackChanges)
        {
            var rawMaterialEntity = _repository.RawMaterial.GetRawMaterial(rawMaterialId, trackChanges);

            if (rawMaterialEntity is null)
                throw new RawMaterialNotFoundException(rawMaterialId);

            _mapper.Map(rawMaterialForUpdate, rawMaterialEntity);

            _repository.Save();
        }
    }
}
