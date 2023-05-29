using System.ComponentModel.DataAnnotations;

namespace JucarAutopartesCRUD.Models
{
    public class Cash : PaymentMethod
    {
        [Required(ErrorMessage = "¡Ingrese un valor!")]
        public string? PaymentUbication { get; set; }

        [Required]
        public string? PaymentReceiver { get; set; }

    }
}
