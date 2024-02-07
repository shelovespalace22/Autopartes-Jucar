using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Products
{
    public class Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StockID { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad disponible!")]
        //[MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Cantidad Disponible")]
        public int QuantityAvailable { get; set; } 

        [Required(ErrorMessage = "¡Ingresa las existencias iniciales!")]
        //[MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Existencias Iniciales")]
        public int InitialStock { get; set; } 

        [Required(ErrorMessage = "¡Ingrese la cantidad de punto de reorden!")]
        //[MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Punto de Reorden")]
        public int ReorderPoint { get; set; } 

        [Required(ErrorMessage = "¡Ingrese el inventario minimo!")]
        //[MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Inventario Minimo")]
        public int MinimumInventory { get; set; }

        [Required(ErrorMessage = "¡Ingrese el inventario máximo!")]
        //[MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Inventario Máximo")]
        public int MaximumInventory { get; set; }

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

        /* Métodos */

        public void setModificationDate()
        {
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        public Guid RawMaterialId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una Materia Prima")]
        [DisplayName("Materia Prima")]
        public RawMaterial? RawMaterial { get; set; }
    }
}
