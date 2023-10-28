//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Entities.Models.Products;

//namespace Contracts.Products
//{
//    public interface ICategoryRepository
//    {
//        /* Crear Categoria */
//        void CreateCategory(Category category);

//        /* Obtener todor los registros de la tabla*/
//        IEnumerable<Category> GetAllCategories(bool trackChanges);

//        /* Obtener un registro especifico */
//        Category GetCategory(Guid categoryId, bool trackChanges);

//        /* Obteniendo Colección de Categorias */
//        IEnumerable<Category> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

//        /* Eliminar Categoria y sus Subcategorias*/
//        void DeleteCategory(Category category);
//    }
//}
