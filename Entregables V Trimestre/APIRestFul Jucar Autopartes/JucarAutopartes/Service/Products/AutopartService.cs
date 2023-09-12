using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Exceptions.NotFound.Products;
using Entities.Models.Products;
using Service.Contracts.Products;
using Shared.DataTransferObjects.Products;

namespace Service.Products
{
    internal sealed class AutopartService : IAutopartService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AutopartService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Obteniendo todas las Autopartes en general */
        public IEnumerable<AutopartDto> GetAllAutoparts(bool trackChanges)
        {
            var autoparts = _repository.Autopart.GetAllAutoparts(trackChanges);

            var autopartsDto = _mapper.Map<IEnumerable<AutopartDto>>(autoparts);

            return autopartsDto;
        }

        /* Obteniendo Autoparte por su Id */
        public AutopartDto GetAutopartById(Guid id, bool trackChanges)
        {
            var autopart = _repository.Autopart.GetAutopartById(id, trackChanges);

            if (autopart is null)
                throw new AutopartNotFoundException(id);

            var autopartDto = _mapper.Map<AutopartDto>(autopart);

            return autopartDto;
        }

        /* Obteniendo las Autopartes de una Subcategoria */

        public IEnumerable<AutopartDto> GetAutoparts(Guid subcategoryId, bool trackChanges)
        {
            var subcategory = _repository.Subcategory.GetSubcategoryById(subcategoryId, trackChanges);

            if (subcategory is null)
                throw new CategoryNotFoundException(subcategoryId);

            var autopartsFromDb = _repository.Autopart.GetAutoparts(subcategoryId, trackChanges);

            var autopartsDto = _mapper.Map<IEnumerable<AutopartDto>>(autopartsFromDb);

            return autopartsDto;
        }

        /* Obtener una Autoparte especifica de una Subcategoria */

        public AutopartDto GetAutopartBySubcategory(Guid subcategoryId, Guid id, bool trackChanges)
        {
            var subcategory = _repository.Subcategory.GetSubcategoryById(subcategoryId, trackChanges);

            if (subcategory is null)
                throw new SubcategoryNotFoundException(subcategoryId);

            var autopartDb = _repository.Autopart.GetAutopartBySubcategory(subcategoryId, id, trackChanges);

            if (autopartDb is null)
                throw new AutopartNotFoundException(id);

            var autopart = _mapper.Map<AutopartDto>(autopartDb);

            return autopart;
        }

        /* Crear una autoparte */

        public AutopartDto CreateAutopartForSubcategory(Guid subcategoryId, AutopartForCreationDto autopartForCreation, bool trackChanges)
        {
            var subcategory = _repository.Subcategory.GetSubcategoryById(subcategoryId, trackChanges);

            if (subcategory is null)
                throw new SubcategoryNotFoundException(subcategoryId);

            var autopartEntity = _mapper.Map<Autopart>(autopartForCreation);

            _repository.Autopart.CreateAutopartForSubcategory(subcategoryId, autopartEntity);

            _repository.Save();

            var autopartToReturn = _mapper.Map<AutopartDto>(autopartEntity);

            return autopartToReturn;
        }

        /* Actualizar una Autoparte */
        public void UpdateAutopartForSubcategory(Guid subcategoryId, Guid id, AutopartForUpdateDto autopartForUpdate, bool subcTrackChanges, bool trackChanges)
        {
            var subcategory = _repository.Subcategory.GetSubcategoryById(subcategoryId, subcTrackChanges);

            if (subcategory is null)
                throw new SubcategoryNotFoundException(subcategoryId);

            var autopartEntity = _repository.Autopart.GetAutopartBySubcategory(subcategoryId, id, trackChanges);

            if (autopartEntity is null)
                throw new AutopartNotFoundException(id);

            _mapper.Map(autopartForUpdate, autopartEntity);

            _repository.Save();
        }
    }
}
