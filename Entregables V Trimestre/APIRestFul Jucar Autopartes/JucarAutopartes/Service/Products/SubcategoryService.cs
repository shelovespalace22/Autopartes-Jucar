//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using AutoMapper;
//using Contracts;
//using Entities.Exceptions;
//using Entities.Exceptions.NotFound.Products;
//using Entities.Models.Products;
//using Service.Contracts.Products;
//using Shared.DataTransferObjects.Products;

//namespace Service.Products
//{
//    internal sealed class SubcategoryService : ISubcategoryService
//    {
//        private readonly IRepositoryManager _repository;
//        private readonly ILoggerManager _logger;
//        private readonly IMapper _mapper;

//        public SubcategoryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
//        {
//            _repository = repository;
//            _logger = logger;
//            _mapper = mapper;
//        }

//        /* Crear una subcategoria */

//        public SubcategoryDto CreateSubcategoryForCategory(Guid categoryId, SubcategoryForCreationDto subcategoryForCreation, bool trackChanges)
//        {
//            var category = _repository.Category.GetCategory(categoryId, trackChanges);

//            if (category is null)
//                throw new CategoryNotFoundException(categoryId);

//            var subcategoryEntity = _mapper.Map<Subcategory>(subcategoryForCreation);

//            _repository.Subcategory.CreateSubcategoryForCategory(categoryId, subcategoryEntity);

//            _repository.Save();

//            var subcategoryToReturn = _mapper.Map<SubcategoryDto>(subcategoryEntity);

//            return subcategoryToReturn;
//        }

//        /* Obtener todas las Subcategorias en general*/
//        public IEnumerable<SubcategoryDto> GetAllSubcategories(bool trackChanges)
//        {
//            var subcategories = _repository.Subcategory.GetAllSubcategories(trackChanges);

//            var subcategoriesDto = _mapper.Map<IEnumerable<SubcategoryDto>>(subcategories);

//            return subcategoriesDto;
//        }

//        /* Obtener una Subcategoria especifica */
//        public SubcategoryDto GetSubcategoryById(Guid id, bool trackChanges)
//        {
//            var subcategory = _repository.Subcategory.GetSubcategoryById(id, trackChanges);

//            if (subcategory is null)
//                throw new SubcategoryNotFoundException(id);

//            var subcategoryDto = _mapper.Map<SubcategoryDto>(subcategory);

//            return subcategoryDto;
//        }

//        /* Obteniendo las Subcategorias de una Categoria */

//        public IEnumerable<SubcategoryDto> GetSubcategories(Guid categoryId, bool trackChanges)
//        {
//            var category = _repository.Category.GetCategory(categoryId, trackChanges);

//            if (category is null)
//                throw new CategoryNotFoundException(categoryId);

//            var subcategoriesFromDb = _repository.Subcategory.GetSubcategories(categoryId, trackChanges);

//            var subcategoriesDto = _mapper.Map<IEnumerable<SubcategoryDto>>(subcategoriesFromDb);

//            return subcategoriesDto;
//        }

//        /* Obtener una Subcategoria especifica de una Categoria */

//        public SubcategoryDto GetSubcategoryByCategory(Guid categoryId, Guid id, bool trackChanges)
//        {
//            var category = _repository.Category.GetCategory(categoryId, trackChanges);

//            if (category is null)
//                throw new CategoryNotFoundException(categoryId);

//            var subcategoryDb = _repository.Subcategory.GetSubcategoryByCategory(categoryId, id, trackChanges);

//            if (subcategoryDb is null)
//                throw new SubcategoryNotFoundException(id);

//            var subcategory = _mapper.Map<SubcategoryDto>(subcategoryDb);

//            return subcategory;
//        }

//        /* Obtener una colección de registros */

//        public IEnumerable<SubcategoryDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges)
//        {
//            if (ids is null)
//                throw new IdParametersBadRequestException();

//            var subcategoryEntities = _repository.Subcategory.GetByIds(ids, trackChanges);

//            if (ids.Count() != subcategoryEntities.Count())
//                throw new CollectionByIdsBadRequestException();

//            var subcategoriesToReturn = _mapper.Map<IEnumerable<SubcategoryDto>>(subcategoryEntities);

//            return subcategoriesToReturn;
//        }

//        /* Actualizar una Subcategoría */

//        public void UpdateSubcategoryForCategory(Guid categoryId, Guid id, SubcategoryForUpdateDto subcategoryForUpdate, bool catTrackChanges, bool subTrackChanges)
//        {
//            var category = _repository.Category.GetCategory(categoryId, catTrackChanges);

//            if (category is null)
//                throw new CategoryNotFoundException(categoryId);

//            var subcategoryEntity = _repository.Subcategory.GetSubcategoryByCategory(categoryId, id, subTrackChanges);

//            if (subcategoryEntity is null)
//                throw new SubcategoryNotFoundException(id);

//            _mapper.Map(subcategoryForUpdate, subcategoryEntity);

//            subcategoryEntity.setModificationDate();

//            _repository.Save();
//        }


//        /* Eliminar una Subcategoria */
//        public void DeleteSubcategoryForCategory(Guid categoryId, Guid id, bool trackChanges)
//        {
//            var category = _repository.Category.GetCategory(categoryId, trackChanges);

//            if (category is null)
//                throw new CategoryNotFoundException(categoryId);

//            var subcategoryForCategory = _repository.Subcategory.GetSubcategoryByCategory(categoryId, id, trackChanges);

//            if (subcategoryForCategory is null)
//                throw new SubcategoryNotFoundException(id);

//            _repository.Subcategory.DeleteSubcategory(subcategoryForCategory);

//            _repository.Save();
//        }
//    }
//}
