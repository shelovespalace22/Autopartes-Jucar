//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using AutoMapper;
//using Contracts;
//using Entities.Exceptions;
//using Entities.Exceptions.BadRequest.Products;
//using Entities.Exceptions.NotFound.Products;
//using Entities.Models.Products;
//using Service.Contracts.Products;
//using Shared.DataTransferObjects.Products;

//namespace Service.Products
//{
//    internal sealed class CategoryService : ICategoryService
//    {
//        private readonly IRepositoryManager _repository;
//        private readonly ILoggerManager _logger;
//        private readonly IMapper _mapper;

//        public CategoryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
//        {
//            _repository = repository;
//            _logger = logger;
//            _mapper = mapper;
//        }

//        /* Crear Categoria */
//        public CategoryDto CreateCategory(CategoryForCreationDto category)
//        {
//            var categoryEntity = _mapper.Map<Category>(category);

//            _repository.Category.CreateCategory(categoryEntity);

//            _repository.Save();

//            var categoryToReturn = _mapper.Map<CategoryDto>(categoryEntity);

//            return categoryToReturn;
//        }

//        /* Crear una colección */
//        public (IEnumerable<CategoryDto> categories, string ids) CreateCategoryCollection(IEnumerable<CategoryForCreationDto> categoryCollection)
//        {
//            if (categoryCollection is null)
//                throw new CategoryCollectionBadRequest();

//            var categoryEntities = _mapper.Map<IEnumerable<Category>>(categoryCollection);

//            foreach (var category in categoryEntities)
//            {
//                _repository.Category.CreateCategory(category);
//            }

//            _repository.Save();

//            var categoryCollectionToReturn = _mapper.Map<IEnumerable<CategoryDto>>(categoryEntities);

//            var ids = string.Join(",", categoryCollectionToReturn.Select(c => c.CategoryId));

//            return (categories: categoryCollectionToReturn, ids);
//        }

//        /* Obtener todos los registros de la tabla */
//        public IEnumerable<CategoryDto> GetAllCategories(bool trackChanges)
//        {
//            var categories = _repository.Category.GetAllCategories(trackChanges);

//            var categoriesDto = _mapper.Map<IEnumerable<CategoryDto>>(categories);

//            return categoriesDto;
//        }

//        /* Obtener un registro especifico */
//        public CategoryDto GetCategory(Guid id, bool trackChanges)
//        {
//            var category = _repository.Category.GetCategory(id, trackChanges);

//            if (category is null)
//                throw new CategoryNotFoundException(id);

//            var categoryDto = _mapper.Map<CategoryDto>(category);

//            return categoryDto;
//        }

//        /* Obtener una colección de registros */

//        public IEnumerable<CategoryDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges)
//        {
//            if (ids is null)
//                throw new IdParametersBadRequestException();

//            var categoryEntities = _repository.Category.GetByIds(ids, trackChanges);

//            if (ids.Count() != categoryEntities.Count())
//                throw new CollectionByIdsBadRequestException();

//            var categoriesToReturn = _mapper.Map<IEnumerable<CategoryDto>>(categoryEntities);

//            return categoriesToReturn;
//        }

//        /* Actualizar una categoria */

//        public void UpdateCategory(Guid categoryId, CategoryForUpdateDto categoryForUpdate, bool trackChanges)
//        {
//            var categoryEntity = _repository.Category.GetCategory(categoryId, trackChanges);

//            if(categoryEntity is null)
//                throw new CategoryNotFoundException(categoryId);

//            _mapper.Map(categoryForUpdate, categoryEntity);

//            categoryEntity.setModificationDate();

//            _repository.Save();
//        }

//        /* Eliminar una categoría */
//        public void DeleteCategory(Guid categoryId, bool trackChanges)
//        {
//            var category = _repository.Category.GetCategory(categoryId, trackChanges);

//            if (category is null)
//                throw new CategoryNotFoundException(categoryId);

//            _repository.Category.DeleteCategory(category);

//            _repository.Save();
//        }

//    }
//}
