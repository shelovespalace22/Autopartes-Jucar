using AutoMapper;
using Entities.Models.Products;
using Shared.DataTransferObjects;

namespace JucarAutopartes
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>();

            CreateMap<Subcategory, SubcategoryDto>();

            CreateMap<Autopart, AutopartDto>();

            CreateMap<AutopartForCreationDto, Autopart>();

            CreateMap<CategoryForCreationDto, Category>();

            CreateMap<SubcategoryForCreationDto, Subcategory>();

            CreateMap<AutopartForUpdateDto, Autopart>();
        }
    }
}
