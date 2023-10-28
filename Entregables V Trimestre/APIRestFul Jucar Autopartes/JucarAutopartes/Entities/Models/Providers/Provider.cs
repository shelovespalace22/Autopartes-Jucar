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
    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProviderID { get; set; }

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

        /* Agregué tres campos nuevos, IdentifierType, IdentifierNumber y Name */

        [Required(ErrorMessage = "¡Ingrese un correo electrónico!")]
        [EmailAddress(ErrorMessage = "¡Ingrese una cuenta de correo electrónico válida!")]
        [DisplayName("Correo Electrónico")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "¡Ingrese el tipo de producto!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Tipo de Producto")]
        public string? ProductType { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public Provider()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        /* Métodos */

        public void setModificationDate()
        {
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //ProviderAddress

        public ICollection<ProviderAddress>? ProviderAddresses { get; set; }

        //ProviderPhone

        public ICollection<ProviderPhone>? ProviderPhones { get; set; }
    }
}
