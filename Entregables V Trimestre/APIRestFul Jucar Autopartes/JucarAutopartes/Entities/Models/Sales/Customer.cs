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
        public Guid CustomerID { get; set; }

        [Required(ErrorMessage = "Ingrese su Tipo de Identificación (NIT, C.C o C.E)")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z.\\s]+$\r\n")]
        [DisplayName("Tipo de Identifiación")]
        public string? IdentifierType { get; set; }

        [Required(ErrorMessage = "Ingrese su Número de Identificación")]
        [MaxLength(10)]
        [RegularExpression("^[0-9]+$\r\n")]
        [DisplayName("Número de Identificación")]
        public string IdentifierNumber { get; set; }

        [Required(ErrorMessage = "Ingrese su Nombre o Razón Social")]
        [MaxLength(100)]
        [RegularExpression("^[A-Za-z.\\s]+$\r\n")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

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

        /* Métodos */

        public void setModificationDate()
        {
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //CustomerAddress

        public ICollection<CustomerAddress> CustomerAddresses { get; set; }

        //CustomerPhone

        public ICollection<CustomerPhone> CustomerPhones { get; set; }

        //Order

        public ICollection<Order> Orders { get; set; }
    }
}
