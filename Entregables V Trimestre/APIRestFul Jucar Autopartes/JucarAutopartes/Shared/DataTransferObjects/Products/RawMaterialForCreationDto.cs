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
    public record RawMaterialForCreationDto : RawMaterialForManipulationDto
    {
        [Required(ErrorMessage = "¡Ingrese el nombre de la Materia Prima!")]
        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 50 cáracteres.")]
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Nombre")]
        public string? Name { get; init; }

        [Required(ErrorMessage = "¡Ingrese la información de stock de la materia prima!")]
        [DisplayName("Información de Stock")]
        public StockForCreationDto? Stock { get; init; }
    }

}
