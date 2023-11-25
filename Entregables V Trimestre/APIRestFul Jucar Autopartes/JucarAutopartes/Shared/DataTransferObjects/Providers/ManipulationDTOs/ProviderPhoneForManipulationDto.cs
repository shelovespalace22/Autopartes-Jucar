using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Providers.ManipulationDTOs
{
    public abstract record ProviderPhoneForManipulationDto
    {
        [Required(ErrorMessage = "¡Escoga el tipo de teléfono!")]
        [MaxLength(20, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 20 cáracteres.")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Tipo de Teléfono")]
        public string? PhoneType { get; init; }

        [Required(ErrorMessage = "¡Ingrese el número teléfonico!")]
        [MaxLength(10, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 10 cáracteres.")]
        [RegularExpression("^\\d{1,9}$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Número de Teléfono")]
        public string? PhoneNumber { get; init; }
    }
}
