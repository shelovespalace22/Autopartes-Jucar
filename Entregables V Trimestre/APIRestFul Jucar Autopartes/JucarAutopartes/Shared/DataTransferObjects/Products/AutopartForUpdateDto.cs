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
    public record AutopartForUpdateDto : AutopartForManipulationDto
    {
        [Required(ErrorMessage = "¡Ingrese el nombre de la autoparte!")]
        [MaxLength(50, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Nombre")]
        public string? Name { get; init; }

        [MaxLength(200, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Descripción")]
        public string? Description { get; init; }

        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Inventario")]
        public int Inventory { get; init; }

        [Required(ErrorMessage = "Ingrese el precio de la autoparte.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Precio")]
        public decimal Value { get; init; }
    }
}
