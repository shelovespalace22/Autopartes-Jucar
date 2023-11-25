using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Sales.ManipulationDTOs
{
    public abstract record ContributionForManipulationDto
    {
        public Guid PaymentMethodId { get; init; }

        [Required(ErrorMessage = "¡Ingrese el monto aportado!")]
        [MaxLength(5, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 5 cáracteres.")]
        [RegularExpression("^\\d+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Monto del Aporte")]
        public decimal AmountPaid { get; init; }

        [Required(ErrorMessage = "¡Ingrese la fecha del pago!")]
        [DisplayName("Fecha del Aporte")]
        public DateTime ContributionDate { get; init; }
    }
}
