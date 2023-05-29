using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class PaymentMethod
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentMethodID { get; set; }

        [Required(ErrorMessage = "¡Ingresa un valor!"), StringLength(50), RegularExpression("^[a-zA-Z]+$")]
        public string? Sender { get; set; }

    }
}
