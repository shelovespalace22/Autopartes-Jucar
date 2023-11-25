using Shared.DataTransferObjects.Providers.ProviderAddress;
using Shared.DataTransferObjects.Providers.ProviderPhone;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects.Providers.ManipulationDTOs;

namespace Shared.DataTransferObjects.Providers.Provider
{
    public record ProviderForCreationDto : ProviderForManipulationDto
    {
        [Required(ErrorMessage = "Ingrese su Tipo de Identificación (NIT, C.C o C.E)")]
        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 50 cáracteres.")]
        [RegularExpression("^[A-Za-z.\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Tipo de Identifiación")]
        public string IdentifierType { get; init; }

        [Required(ErrorMessage = "Ingrese su Número de Identificación")]
        [MaxLength(10, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 10 cáracteres.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Número de Identificación")]
        public string IdentifierNumber { get; init; }

        [Required(ErrorMessage = "Ingrese su Nombre o Razón Social")]
        [MaxLength(100, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 100 cáracteres.")]
        [RegularExpression("^[A-Za-z.\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Nombre")]
        public string Name { get; init; }

        [Required(ErrorMessage = "¡Ingrese un correo electrónico!")]
        [EmailAddress(ErrorMessage = "¡Ingrese una cuenta de correo electrónico válida!")]
        [DisplayName("Correo Electrónico")]
        public string EmailAddress { get; init; }

        [Required(ErrorMessage = "¡Ingrese el tipo de producto!")]
        [MaxLength(50, ErrorMessage = "La longitud máxima permitida para el campo {0} es de 50 cáracteres.")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Tipo de Producto")]
        public string ProductType { get; init; }

        ICollection<ProviderAddressForCreationDto>? ProviderAddresses;

        ICollection<ProviderPhoneForCreationDto>? ProviderPhones;
    }
}
