using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products.ManipulationDTOs
{
    public abstract record LossForManipulationDto
    {
        [Required(ErrorMessage = "¡Ingrese la cantidad perdida!")]
        [MaxLength(5, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 5 cáracteres.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Cantidad Perdida")]
        public int AmountLoss { get; init; }

        [Required(ErrorMessage = "¡Ingrese el responsable!")]
        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 50 cáracteres")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Responsable")]
        public string? Responsible { get; init; }

        [Required(ErrorMessage = "¡Ingrese el motivo de perdida!")]
        [MaxLength(150, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 150 cáracteres.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Motivo")]
        public string? Reason { get; init; }

        [Required(ErrorMessage = "¡Ingrese la fecha de la perdida!")]
        [DisplayName("Fecha de Perdida")]
        public DateTime LossDate { get; init; }
    }
}
