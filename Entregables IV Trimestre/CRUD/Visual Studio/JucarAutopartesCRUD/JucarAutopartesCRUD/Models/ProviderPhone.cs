using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class ProviderPhone
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProviderPhoneID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(20)]
        public string? PhoneType { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(10), RegularExpression("^[0-9]{10}$")]
        public string? PhoneNumber { get; set; }

    }
}
