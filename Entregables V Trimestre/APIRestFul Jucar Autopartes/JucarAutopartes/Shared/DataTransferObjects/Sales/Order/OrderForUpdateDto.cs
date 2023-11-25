using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects.Sales.ManipulationDTOs;

namespace Shared.DataTransferObjects.Sales.Order
{
    public record OrderForUpdateDto : OrderForManipulationDto
    {
        [Required(ErrorMessage = "Ingrese la Fecha del Pedido")]
        [DisplayName("Fecha del Pedido")]
        public DateTime OrderDate { get; init; }

        public Guid CustomerId { get; init; }

        [DisplayName("Total de Venta")]
        public decimal? Total { get; set; }

        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 50 cáracteres.")]
        [DisplayName("Estado de Pago")]
        public string? PaymentStatus { get; init; }

        [MaxLength(100, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 100 cáracteres.")]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Dirección de Envío")]
        public string? ShippingAddress { get; init; }

        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 50 cáracteres.")]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Estado de Envío")]
        public string? ShippingStatus { get; init; }

        [MaxLength(200, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 200 cáracteres.")]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Observación")]
        public string? Observation { get; init; }
    }
}
