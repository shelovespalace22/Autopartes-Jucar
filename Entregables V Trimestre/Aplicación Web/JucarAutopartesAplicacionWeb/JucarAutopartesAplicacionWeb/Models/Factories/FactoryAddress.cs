using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using JucarAutopartesAplicacionWeb.Models.Ubications;

namespace JucarAutopartesAplicacionWeb.Models.Factories
{
    public class FactoryAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FactoryAddressID { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; }

        [Required]
        [DisplayName("Creación de Registro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación de Registro")]
        public DateTime ModificationDate { get; set; }

        //Constructor
        public FactoryAddress()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //Factory

        public int FactoryID { get; set; }
        public Factory? Factory { get; set; }

        //Address

        public int AddressID { get; set; }
        public Address? Address { get; set; }
    }
}
