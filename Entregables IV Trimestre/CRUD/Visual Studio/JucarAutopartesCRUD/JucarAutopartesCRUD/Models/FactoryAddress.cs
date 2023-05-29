using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class FactoryAddress
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FactoryAddressID { get; set; }

        [Required]
        public int ModificationDate { get; set; }
    }
}
