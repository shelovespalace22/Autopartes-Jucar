using AutoMapper;
using JucarAutopartesAplicacionWeb.Models.Products;
using JucarAutopartesAplicacionWeb.Models.ViewModels.Autoparts;

namespace JucarAutopartesAplicacionWeb.Services.Automapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //CreateMap<SourceClass, DestinationClass>();
            CreateMap<Autopart, AutopartsViewModel>();
            CreateMap<AutopartMaterial, AutopartsViewModel>();
            CreateMap<PriceHistory, AutopartsViewModel>();
            CreateMap<Inventory, AutopartsViewModel>();
        }
    }
}
