using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Sales
{
    public class CustomerAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerAddressID { get; set; }

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
        public CustomerAddress()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //Customer 

        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }

        //Address

        public int AddressID { get; set; }
        public Address? Address { get; set; }
    }
}
