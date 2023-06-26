using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using JucarAutopartesAplicacionWeb.Models.Products;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesAplicacionWeb.Models.ViewModels.Autoparts
{
    public class AutopartsViewModel
    {
        public Autopart? Autopart { get; set; }
        public Inventory? Inventory { get; set; }
        public PriceHistory? PriceHistory { get; set; }
        public AutopartMaterial? AutopartMaterial { get; set; }
    }
}
