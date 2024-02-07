using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products.ManipulationDTOs
{
    public abstract record CategoryForManipulationDto 
    {
        [Required(ErrorMessage = "¡Ingrese el nombre de la categoría!")]
        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo Nombre es de 50 cáracteres.")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Nombre")]
        public string? Name { get; init; }

        IEnumerable<SubcategoryForCreationDto>? Subcategories;
    }
}
