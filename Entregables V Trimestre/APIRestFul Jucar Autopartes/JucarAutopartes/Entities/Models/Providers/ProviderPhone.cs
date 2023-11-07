using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Providers
{
    public class ProviderPhone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProviderPhoneID { get; set; }

        [Required(ErrorMessage = "¡Escoga el tipo de teléfono!")]
        [MaxLength(20)]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Tipo de Teléfono")]
        public string? PhoneType { get; set; }

        [Required(ErrorMessage = "¡Ingrese el número teléfonico!")]
        [MaxLength(10)]
        [RegularExpression("^\\d{1,9}$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Número de Teléfono")]
        public string? PhoneNumber { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }


        //Constructor

        public ProviderPhone()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        public Guid ProviderId { get; set; }
        public Provider? Provider { get; set; }
    }
}
