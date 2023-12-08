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
    public class Loss
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LossID { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad perdida!")]
        [MaxLength(5)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Cantidad Perdida")]
        public int AmountLoss { get; set; }

        [Required(ErrorMessage = "¡Ingrese el responsable!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Responsable")]
        public string? Responsible { get; set; }

        /* Eliminé la propiedad 'Place' */

        [Required(ErrorMessage = "¡Ingrese el motivo de perdida!")]
        [MaxLength(150)]
        [RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Motivo")]
        public string? Reason { get; set; }

        [Required(ErrorMessage = "¡Ingrese la fecha de la perdida!")]
        [DisplayName("Fecha de Perdida")]
        public DateTime LossDate { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public Loss()
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

        public Guid AutopartId { get; set; }
        public Autopart? Autopart { get; set; }
    }
}
