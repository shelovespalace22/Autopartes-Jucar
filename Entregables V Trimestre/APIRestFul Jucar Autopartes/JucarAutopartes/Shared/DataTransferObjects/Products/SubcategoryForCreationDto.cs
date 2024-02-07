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
    public record SubcategoryForCreationDto : SubcategoryForManipulationDto
    {
        [Required(ErrorMessage = "¡Ingrese un nombre para la subcategoría!")]
        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 50 cáracteres.")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Nombre")]
        public string? Name { get; init; }

        IEnumerable<AutopartForCreationDto>? Autoparts;
    }
}
