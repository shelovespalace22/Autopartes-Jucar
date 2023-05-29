using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class CustomerAddress
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerAddressID { get; set; }

        [Required]
        public DateTime ModificationDate { get; set; }
    }
}
