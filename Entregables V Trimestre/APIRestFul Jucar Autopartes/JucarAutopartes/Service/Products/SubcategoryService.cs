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
            await CheckIfCategoryExists(categoryId, trackChanges);

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
            var subcategory = await GetSubcategoryAndCheckIfItExists(id, trackChanges);

            var subcategoryDto = _mapper.Map<SubcategoryDto>(subcategory);

            return subcategoryDto;
        }

        /* Obteniendo las Subcategorias de una Categoria */
        public async Task<IEnumerable<SubcategoryDto>> GetSubcategoriesAsync(Guid categoryId, bool trackChanges)
        {
            await CheckIfCategoryExists(categoryId, trackChanges);

            var subcategoriesFromDb = await _repository.Subcategory.GetSubcategoriesAsync(categoryId, trackChanges);

            var subcategoriesDto = _mapper.Map<IEnumerable<SubcategoryDto>>(subcategoriesFromDb);

            return subcategoriesDto;
        }

        /* Obtener una Subcategoria especifica de una Categoria */
        public async Task<SubcategoryDto> GetSubcategoryByCategoryAsync(Guid categoryId, Guid id, bool trackChanges)
        {
            await CheckIfCategoryExists(categoryId, trackChanges);

            var subcategoryDb = await GetSubcategoryForCategoryAndCheckIfItExists(categoryId, id, trackChanges);

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
            await CheckIfCategoryExists(categoryId, catTrackChanges);

            var subcategoryDb = await GetSubcategoryForCategoryAndCheckIfItExists(categoryId, id, subTrackChanges);

            _mapper.Map(subcategoryForUpdate, subcategoryDb);

            subcategoryDb.setModificationDate();

            await _repository.SaveAsync();
        }

        /* Eliminar una Subcategoria */
        public async Task DeleteSubcategoryForCategoryAsync(Guid categoryId, Guid id, bool trackChanges)
        {
            await CheckIfCategoryExists(categoryId, trackChanges);

            var subcategoryDb = await GetSubcategoryForCategoryAndCheckIfItExists(categoryId, id, trackChanges); 

            _repository.Subcategory.DeleteSubcategory(subcategoryDb);

            await _repository.SaveAsync();
        }





        /* <----- Métodos Privados -----> */

        private async Task<Subcategory> GetSubcategoryAndCheckIfItExists(Guid id, bool trackChanges)
        {
            var subcategory = await _repository.Subcategory.GetSubcategoryByIdAsync(id, trackChanges);

            if (subcategory is null)
                throw new SubcategoryNotFoundException(id);

            return subcategory;
        }


        private async Task CheckIfCategoryExists(Guid categoryId, bool trackChanges)
        {
            var category = await _repository.Category.GetCategoryAsync(categoryId, trackChanges);

            if (category is null)
                throw new CategoryNotFoundException(categoryId);
        }


        private async Task<Subcategory> GetSubcategoryForCategoryAndCheckIfItExists(Guid categoryId, Guid id, bool trackChanges)
        {
            var subcategoryDb = await _repository.Subcategory.GetSubcategoryByCategoryAsync(categoryId, id, trackChanges);

            if (subcategoryDb is null)
                throw new SubcategoryNotFoundException(id);

            return subcategoryDb;
        }
    }
}
