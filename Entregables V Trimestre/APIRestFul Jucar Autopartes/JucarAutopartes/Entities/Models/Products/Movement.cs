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
    public class Movement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MovementID { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad del movimiento!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Cantidad")]
        public int Quantity { get; set; } 

        [Required(ErrorMessage = "Debe indicar si el movimiento es una Salida o Entrada")]
        [MaxLength(20)]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Tipo de Movimiento")]
        public string? MovementType { get; set; } 

        [Required(ErrorMessage = "¡Ingrese la fecha del movimiento!")]
        [DisplayName("Fecha del Movimiento")]
        public DateTime MovementDate { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor 

        public Movement()
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
        public RawMaterial? RawMaterial { get; set; }

    }
}
