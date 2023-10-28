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
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "¡Ingrese una cantidad disponible válida!")]
        [DisplayName("Cantidad Disponible")]
        public int QuantityAvailable { get; set; } /* Cambié el tipo de string a int */

        [Required(ErrorMessage = "¡Ingresa las existencias iniciales!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "¡Ingrese existencias iniciales válidas!")]
        [DisplayName("Existencias Iniciales")]
        public int InitialStock { get; set; } /* Cambié el tipo de string a int */

        [Required(ErrorMessage = "¡Ingrese la cantidad de punto de reorden!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "¡Ingrese un punto de reorden válido!")]
        [DisplayName("Punto de Reorden")]
        public int ReorderPoint { get; set; } /* Cambié el tipo de string a int */

        [Required(ErrorMessage = "¡Ingrese el inventario minimo!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "¡Ingrese un inventario mínimo válido!")]
        [DisplayName("Inventario Minimo")]
        public int MinimumInventory { get; set; } /* Cambié el tipo de string a int */

        [Required(ErrorMessage = "¡Ingrese el inventario máximo!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "¡Ingrese un inventario máximo válido!")]
        [DisplayName("Inventario Máximo")]
        public int MaximumInventory { get; set; } /* Cambié el tipo de string a int */

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
