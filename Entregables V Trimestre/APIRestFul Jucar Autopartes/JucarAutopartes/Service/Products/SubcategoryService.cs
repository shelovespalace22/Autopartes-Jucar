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
    internal sealed class SubcategoryService : ISubcategoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SubcategoryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear una subcategoria */
        public async Task<SubcategoryDto> CreateSubcategoryForCategoryAsync(Guid categoryId, SubcategoryForCreationDto subcategoryForCreation, bool trackChanges)
        {
            var category = await _repository.Category.GetCategoryAsync(categoryId, trackChanges);

            if (category is null)
                throw new CategoryNotFoundException(categoryId);

            var subcategoryEntity = _mapper.Map<Subcategory>(subcategoryForCreation);

            _repository.Subcategory.CreateSubcategoryForCategory(categoryId, subcategoryEntity);

            await _repository.SaveAsync();

            var subcategoryToReturn = _mapper.Map<SubcategoryDto>(subcategoryEntity);

            return subcategoryToReturn;
        }

        /* Obtener todas las Subcategorias en general*/
        public async Task<IEnumerable<SubcategoryDto>> GetAllSubcategoriesAsync(bool trackChanges)
        {
            var subcategories = await _repository.Subcategory.GetAllSubcategoriesAsync(trackChanges);

            var subcategoriesDto = _mapper.Map<IEnumerable<SubcategoryDto>>(subcategories);

            return subcategoriesDto;
        }

        /* Obtener una Subcategoria especifica */
        public async Task<SubcategoryDto> GetSubcategoryByIdAsync(Guid id, bool trackChanges)
        {
            var subcategory = await _repository.Subcategory.GetSubcategoryByIdAsync(id, trackChanges);

            if (subcategory is null)
                throw new SubcategoryNotFoundException(id);

            var subcategoryDto = _mapper.Map<SubcategoryDto>(subcategory);

            return subcategoryDto;
        }

        /* Obteniendo las Subcategorias de una Categoria */
        public async Task<IEnumerable<SubcategoryDto>> GetSubcategoriesAsync(Guid categoryId, bool trackChanges)
        {
            var category = await _repository.Category.GetCategoryAsync(categoryId, trackChanges);

            if (category is null)
                throw new CategoryNotFoundException(categoryId);

            var subcategoriesFromDb = await _repository.Subcategory.GetSubcategoriesAsync(categoryId, trackChanges);

            var subcategoriesDto = _mapper.Map<IEnumerable<SubcategoryDto>>(subcategoriesFromDb);

            return subcategoriesDto;
        }

        /* Obtener una Subcategoria especifica de una Categoria */
        public async Task<SubcategoryDto> GetSubcategoryByCategoryAsync(Guid categoryId, Guid id, bool trackChanges)
        {
            var category = await _repository.Category.GetCategoryAsync(categoryId, trackChanges);

            if (category is null)
                throw new CategoryNotFoundException(categoryId);

            var subcategoryDb = await _repository.Subcategory.GetSubcategoryByCategoryAsync(categoryId, id, trackChanges);

            if (subcategoryDb is null)
                throw new SubcategoryNotFoundException(id);

            var subcategory = _mapper.Map<SubcategoryDto>(subcategoryDb);

            return subcategory;
        }

        /* Obtener una colección de registros */
        public async Task<IEnumerable<SubcategoryDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var subcategoryEntities = await _repository.Subcategory.GetByIdsAsync(ids, trackChanges);

            if (ids.Count() != subcategoryEntities.Count())
                throw new CollectionByIdsBadRequestException();

            var subcategoriesToReturn = _mapper.Map<IEnumerable<SubcategoryDto>>(subcategoryEntities);

            return subcategoriesToReturn;
        }

        /* Actualizar una Subcategoría */
        public async Task UpdateSubcategoryForCategoryAsync(Guid categoryId, Guid id, SubcategoryForUpdateDto subcategoryForUpdate, bool catTrackChanges, bool subTrackChanges)
        {
            var category = await _repository.Category.GetCategoryAsync(categoryId, catTrackChanges);

            if (category is null)
                throw new CategoryNotFoundException(categoryId);

            var subcategoryEntity = await _repository.Subcategory.GetSubcategoryByCategoryAsync(categoryId, id, subTrackChanges);

            if (subcategoryEntity is null)
                throw new SubcategoryNotFoundException(id);

            _mapper.Map(subcategoryForUpdate, subcategoryEntity);

            subcategoryEntity.setModificationDate();

            await _repository.SaveAsync();
        }

        /* Eliminar una Subcategoria */
        public async Task DeleteSubcategoryForCategoryAsync(Guid categoryId, Guid id, bool trackChanges)
        {
            var category = await _repository.Category.GetCategoryAsync(categoryId, trackChanges);

            if (category is null)
                throw new CategoryNotFoundException(categoryId);

            var subcategoryForCategory = await _repository.Subcategory.GetSubcategoryByCategoryAsync(categoryId, id, trackChanges);

            if (subcategoryForCategory is null)
                throw new SubcategoryNotFoundException(id);

            _repository.Subcategory.DeleteSubcategory(subcategoryForCategory);

            await _repository.SaveAsync();
        }
    }
}
