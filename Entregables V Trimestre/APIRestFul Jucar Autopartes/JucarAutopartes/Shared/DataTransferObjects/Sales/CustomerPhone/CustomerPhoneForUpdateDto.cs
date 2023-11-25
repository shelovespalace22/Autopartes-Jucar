using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects.Sales.ManipulationDTOs;

namespace Shared.DataTransferObjects.Sales.CustomerPhone
{
    public record CustomerPhoneForUpdateDto : CustomerPhoneForManipulationDto
    {
        [Required(ErrorMessage = "¡Ingrese el tipo de teléfono!")]
        [MaxLength(30, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 30 cáracteres.")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Tipo de Teléfono")]
        public string? PhoneType { get; init; }

        [Required(ErrorMessage = "¡Ingrese el número de teléfono!")]
        [MaxLength(10, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 10 cáracteres.")]
        [RegularExpression("\\d{1,10}$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Número de Teléfono")]
        public string? PhoneNumber { get; init; }
    }
}
