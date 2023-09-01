using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Users
{
    public class UserAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAddressID { get; set; }

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
        public UserAddress()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //User

        //public int UserID { get; set; }
        public User? User { get; set; }

        //Address

        public int AddressID { get; set; }
        public Address? Address { get; set; }
    }
}
