using System.ComponentModel.DataAnnotations;

namespace JucarAutopartesCRUD.Models
{
    public class LegalCustomer : Customer
    {
        [Required(ErrorMessage = "¡Ingresa un valor!"), StringLength(50), RegularExpression("^[a-zA-Z]+$")]
        public string? BussinesName { get; set; }

        [Required(ErrorMessage = "¡Ingresa un valor!"), StringLength(9), RegularExpression("^[0-9]{9}$")]
        public string? NIT { get; set; }
    }
}
