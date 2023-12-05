using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects.Sales.ManipulationDTOs;

namespace Shared.DataTransferObjects.Sales.OrderDetail
{
    public record OrderDetailForUpdateDto : OrderDetailForManipulationDto
    {
        public Guid AutopartId { get; init; }

        [Required(ErrorMessage = "¡Ingresa la cantidad del item!")]
        //[MaxLength(5, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 5 cáracteres.")]
        [RegularExpression("^\\d+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Cantidad")]
        public int Quantity { get; init; }
    }
}
