using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class ProviderAddress
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProviderAddressID { get; set; }

        [Required]
        public DateTime ModificationDate { get; set; }
    }
}
