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


            /* Materias Primas */

            CreateMap<RawMaterial, RawMaterialDto>();

            CreateMap<RawMaterialForCreationDto, RawMaterial>();

            CreateMap<RawMaterialForUpdateDto, RawMaterial>();


            /* Stock Materias Primas */

            CreateMap<Stock, StockDto>();

            CreateMap<StockForCreationDto, Stock>();

            CreateMap<StockForUpdateDto, Stock>();


            /* Perdidas */

            CreateMap<Loss, LossDto>();

            CreateMap<LossForCreationDto, Loss>();

            CreateMap<LossForUpdateDto, Loss>();


            /* Movimientos */

            CreateMap<Movement, MovementDto>();

            CreateMap<MovementForCreationDto, Movement>();

            CreateMap<MovementForUpdateDto, Movement>();

        }
    }
}
