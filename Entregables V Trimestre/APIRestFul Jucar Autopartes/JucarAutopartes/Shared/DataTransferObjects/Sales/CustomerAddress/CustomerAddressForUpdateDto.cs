using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects.Sales.ManipulationDTOs;

namespace Shared.DataTransferObjects.Sales.CustomerAddress
{
    public record CustomerAddressForUpdateDto : CustomerForManipulationDto
    {
        [Required(ErrorMessage = "Ingresa la dirección")]
        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 50 cáracteres.")]
        [RegularExpression("^(?:Cra\\.|Carrera|Calle|Cl|Avenida|Av|Transversal|Trv|Diagonal|Dg)\\.?\\s*\\d{1,5}\\s(?:\\w{2,})\\s#-?\\d{1,5}(?:-\\d{1,4})?$\r\n", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Dirección")]
        public string? Address { get; init; }

        [Required(ErrorMessage = "Ingresa el tipo de dirección")]
        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 50 cáracteres.")]
        [RegularExpression("^[A-Za-z.\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Tipo de Dirección")]
        public string? AddressType { get; init; }

        public Guid NeighborhoodId { get; init; }
    }
}
