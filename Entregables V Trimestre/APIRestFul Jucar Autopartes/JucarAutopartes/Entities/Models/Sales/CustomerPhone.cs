using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Sales
{
    public class CustomerPhone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerPhoneID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el tipo de teléfono!")]
        [MaxLength(30)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Tipo de Teléfono")]
        public string? PhoneType { get; set; }

        [Required(ErrorMessage = "¡Ingrese el número de teléfono!")]
        [MaxLength(10)]
        [RegularExpression("\\d{1,10}$")]
        [DisplayName("Número de Teléfono")]
        public string? PhoneNumber { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public CustomerPhone()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //Customer 

        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }
    }
}
