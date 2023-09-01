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
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un correo electónico!")]
        [EmailAddress(ErrorMessage = "¡Ingrese una cuenta de correo válida!")]
        [DisplayName("Correo Electrónico")]
        public string? Email { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Registro")]
        public DateTime ModificationDate { get; set; }

        //Constructor 

        public Customer()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //CustomerAddress

        public ICollection<CustomerAddress> CustomerAddresses { get; set; }

        //Order

        public ICollection<Order> Orders { get; set; }
    }
}
