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
    public class Autopart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutopartID { get; set; }

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

        public Autopart()
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
        public int SubcategoryID { get; set; }

        [DisplayName("Subcategoría")]
        public Subcategory? Subcategory { get; set; }

        //Loss

        public ICollection<Loss>? Losses { get; set; }

        //PriceHistory

        public ICollection<PriceHistory>? PriceHistories { get; set; }

        //Inventory

        [DisplayName("Inventario")]
        public Inventory? Inventory { get; set; }

        //AutopartMaterial

        public ICollection<AutopartMaterial>? AutopartMaterials { get; set; }

        //BillDetail

        public ICollection<BillDetail>? BillDetails { get; set; }

        //OrderDetail

        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
