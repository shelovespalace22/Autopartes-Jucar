using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects.Products.ManipulationDTOs;

namespace Shared.DataTransferObjects.Products
{
    public record MovementForCreationDto : MovementForManipulationDto
    {
        [Required(ErrorMessage = "¡Ingrese la cantidad del movimiento!")]
        //[MaxLength(3, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 3 cáracteres.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Cantidad")]
        public int Quantity { get; init; }

        [Required(ErrorMessage = "Debe indicar si el movimiento es una Salida o Entrada")]
        [MaxLength(20, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 20 cáracteres.")]
        [RegularExpression("^(Entrada|entrada|Salida|salida)$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten los valores 'Entrada' o 'Salida'.")]
        [DisplayName("Tipo de Movimiento")]
        public string? MovementType { get; init; }

        [Required(ErrorMessage = "¡Ingrese la fecha del movimiento!")]
        [DisplayName("Fecha del Movimiento")]
        public DateTime MovementDate { get; init; }
    }
}
