using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesAplicacionWeb.Models.Products
{
    public class Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockID { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad disponible!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Cantidad Disponible")]
        public string? QuantityAvailable { get; set; }

        [Required(ErrorMessage = "¡Ingresa las existencias iniciales!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Existencias Iniciales")]
        public string? InitialStock { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad de punto de reorden!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Punto de Reorden")]
        public string? ReorderPoint { get; set; }

        [Required(ErrorMessage = "¡Ingrese el inventario minimo!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Inventario Minimo")]
        public string? MinimumInventory { get; set; }

        [Required(ErrorMessage = "¡Ingrese el inventario máximo!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Inventario Máximo")]
        public string? MaximumInventory { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor 

        public Stock()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        public int RawMaterialID { get; set; }
        public RawMaterial? RawMaterial { get; set; }
    }
}
