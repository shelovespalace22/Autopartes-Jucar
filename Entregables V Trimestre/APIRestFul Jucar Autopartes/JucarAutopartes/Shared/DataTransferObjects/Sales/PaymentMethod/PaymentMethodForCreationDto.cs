using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects.Sales.ManipulationDTOs;

namespace Shared.DataTransferObjects.Sales.PaymentMethod
{
    public record PaymentMethodForCreationDto : PaymentMethodForManipulationDto
    {
        [Required(ErrorMessage = "¡Ingrese el nombre del metodo de pago!")]
        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 50 cáracteres.")]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Metodo de Pago")]
        public string? PaymentMethodName { get; init; }
    }
}
