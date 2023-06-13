using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JucarAutopartesAplicacionWeb.Models.Sales;

namespace JucarAutopartesAplicacionWeb.Models.Products
{
    public class Autopart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutopartID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el nombre de la autoparte!")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z]+$")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "¡Ingrese una descripción para la autoparte!")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z]+$")]
        [DisplayName("Descripción")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "¡Ingrese el peso de la autoparte! (en Kilogramos)")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Peso Kgs")]
        public string? WeightKgs { get; set; }

        [Required(ErrorMessage = "¡Ingrese la altura de la autoparte! (en Centimetros)")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Altura Cm")]
        public string? HeightCm { get; set; }

        [Required(ErrorMessage = "¡Ingrese el largo de la autoparte! (en Centimetros)")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Largo Cm")]
        public string? LengthCm { get; set; }

        [Required(ErrorMessage = "¡Ingrese la zona del vehiculo a la que pertenece!")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z]+$")]
        [DisplayName("Zona del Vehículo")]
        public string? VehicleZone { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate{ get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }


        //Constructor

        public Autopart()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Subcategory
        public int SubcategoryID { get; set; }
        public Subcategory? Subcategory { get; set; }

        //Loss

        public ICollection<Loss> Losses { get; set; }

        //PriceHistory

        public ICollection<PriceHistory> PriceHistories { get; set; }

        //Inventory

        public Inventory? Inventory { get; set; }

        //AutopartMaterial

        public ICollection<AutopartMaterial> AutopartMaterials { get; set; }

        //BillDetail

        public ICollection<BillDetail> BillDetails { get; set; }

        //OrderDetail

        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
