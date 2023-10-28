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
    public class Factory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid FactoryID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el numero NIT!")]
        [MaxLength(9)]
        [RegularExpression("^[0-9]{1,9}$")]
        [DisplayName("NIT")]
        public string? NIT { get; set; }

        [Required(ErrorMessage = "¡Ingresa la razón social!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Razón Social")]
        public string? BusinessName { get; set; }

        [Required(ErrorMessage = "¡Ingrese el correo electrónico!")]
        [EmailAddress]
        [DisplayName("Correo Electrónico")]
        public string? EmailAddress { get; set; }

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

        public Factory()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //FactoryPhone

        public ICollection<FactoryPhone> FactoryPhones { get; set; }

        //Warehouse

        public ICollection<Warehouse> Warehouses { get; set; }

        //FactoryAddress
        public ICollection<FactoryAddress> FactoryAddresses { get; set; }
    }
}


