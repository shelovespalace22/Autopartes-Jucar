using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Factories;

namespace Entities.Models.Products
{
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryID { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad disponible del producto!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Cantidad Disponible")]
        public string? QuantityAvailable { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Última Actualización")]
        public DateTime UltimateModificationDate { get; set; }

        //Constructor

        public Inventory()
        {
            CreationDate = DateTime.Now;
            UltimateModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Autopart

        public int AutopartID { get; set; }
        public Autopart? Autopart { get; set; }

        //Shelving

        public ICollection<Shelving>? Shelvings { get; set; }
    }
}
