using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Sales;

namespace Entities.Models.Products
{
    public class AutopartViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AutopartID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el nombre de la autoparte!")]
        [MaxLength(50, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "¡Ingrese una descripción para la autoparte!")]
        [MaxLength(200, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$")]
        [DisplayName("Descripción")]
        public string? Description { get; set; }

        [MaxLength(3, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Peso Kgs")]
        public string? WeightKgs { get; set; }

        [MaxLength(3, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Altura Cm")]
        public string? HeightCm { get; set; }

        [MaxLength(3, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Largo Cm")]
        public string? LengthCm { get; set; }

        [Required(ErrorMessage = "¡Ingrese la zona del vehiculo a la que pertenece!")]
        [MaxLength(50, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$")]
        [DisplayName("Zona del Vehículo")]
        public string? VehicleZone { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }


        //Constructor

        public AutopartViewModel()
        {
            WeightKgs = "0";
            HeightCm = "0";
            LengthCm = "0";
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Subcategory
        public Guid SubcategoryId { get; set; }

        [DisplayName("Subcategoría")]
        public SubcategoryViewModel? Subcategory { get; set; }

        //Loss

        public ICollection<LossViewModel>? Losses { get; set; }

        //PriceHistory

        public ICollection<PriceHistoryViewModel>? PriceHistories { get; set; }

        //Inventory

        [DisplayName("Inventario")]
        public InventoryViewModel? Inventory { get; set; }

        //AutopartMaterial

        public ICollection<AutopartMaterialViewModel>? AutopartMaterials { get; set; }

        //BillDetail

        public ICollection<BillDetailViewModel>? BillDetails { get; set; }

        //OrderDetail

        public ICollection<OrderDetailViewModel>? OrderDetails { get; set; }
    }
}
