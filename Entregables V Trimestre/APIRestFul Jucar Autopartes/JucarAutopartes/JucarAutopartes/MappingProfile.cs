using AutoMapper;
using Entities.Models.Products;
using Shared.DataTransferObjects.Products;

namespace JucarAutopartes
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /* Categorias */

            CreateMap<Category, CategoryDto>();

            CreateMap<CategoryForCreationDto, Category>();

            CreateMap<CategoryForUpdateDto, Category>();


            /* Subcategorias */

            CreateMap<Subcategory, SubcategoryDto>();

            CreateMap<SubcategoryForCreationDto, Subcategory>();

            CreateMap<SubcategoryForUpdateDto, Subcategory>();


            /* Autopartes */

            CreateMap<Autopart, AutopartDto>();

            CreateMap<AutopartForCreationDto, Autopart>();

            CreateMap<AutopartForUpdateDto, Autopart>();
        }
    }
}
