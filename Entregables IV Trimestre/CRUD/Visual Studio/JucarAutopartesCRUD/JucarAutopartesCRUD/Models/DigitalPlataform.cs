using System.ComponentModel.DataAnnotations;

namespace JucarAutopartesCRUD.Models
{
    public class DigitalPlataform : PaymentMethod
    {
        [Required(ErrorMessage = "¡Ingresa un valor!"), StringLength(50), RegularExpression("^[a-zA-Z]+$")]
        public string? BankingEntity { get; set; }

        [Required]
        public int PaymentReference { get; set; }

        [Required]
        public int DestinationNumber { get; set; }
    }
}
