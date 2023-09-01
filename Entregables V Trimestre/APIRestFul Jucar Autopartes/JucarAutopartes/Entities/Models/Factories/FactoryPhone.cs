using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Factories
{
    public class FactoryPhone
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid FactoryPhoneID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el tipo de teléfono!")]
        [DisplayName("Tipo de Teléfono")]
        public string? PhoneType { get; set; }

        [Required(ErrorMessage = "¡Ingrese el número de teléfono!")]
        [DisplayName("Número de Teléfono")]
        public string? PhoneNumber { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public FactoryPhone()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        public Guid FactoryID { get; set; }
        public Factory? Factory { get; set; }
    }
}
