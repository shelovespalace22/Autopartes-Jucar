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
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid InventoryID { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad disponible del producto!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Cantidad Disponible")]
        public int QuantityAvailable { get; set; } /* Cambié el tipo de string a int */

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

        public Guid AutopartId { get; set; }
        public Autopart? Autopart { get; set; }

        /* Eliminé la relación con Shelving */
    }
}
