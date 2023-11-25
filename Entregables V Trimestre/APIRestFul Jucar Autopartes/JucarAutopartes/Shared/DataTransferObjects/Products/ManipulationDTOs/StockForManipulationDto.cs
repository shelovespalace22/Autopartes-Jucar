using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.Products.ManipulationDTOs
{
    public abstract record StockForManipulationDto
    {
        [Required(ErrorMessage = "¡Ingrese la cantidad disponible!")]
        [MaxLength(3, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 3 cáracteres.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Cantidad Disponible")]
        public int QuantityAvailable { get; init; }

        [Required(ErrorMessage = "¡Ingresa las existencias iniciales!")]
        [MaxLength(3, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 3 cáracteres.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Existencias Iniciales")]
        public int InitialStock { get; init; }

        [Required(ErrorMessage = "¡Ingrese la cantidad de punto de reorden!")]
        [MaxLength(3, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 3 cáracteres.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Punto de Reorden")]
        public int ReorderPoint { get; init; }

        [Required(ErrorMessage = "¡Ingrese el inventario minimo!")]
        [MaxLength(3, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 3 cáracteres.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Inventario Minimo")]
        public int MinimumInventory { get; init; }

        [Required(ErrorMessage = "¡Ingrese el inventario máximo!")]
        [MaxLength(3, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 3 cáracteres.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Inventario Máximo")]
        public int MaximumInventory { get; init; }
    }
}
