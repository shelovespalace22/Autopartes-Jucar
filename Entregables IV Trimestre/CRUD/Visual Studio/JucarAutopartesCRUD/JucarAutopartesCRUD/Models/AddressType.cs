using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class AddressType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressTypeID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(30), RegularExpression("^[a-zA-Z]+$")]
        public string? Type { get; set; }

        [Required]
        public DateTime ModificationDate { get; set; }
    }
}
