using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JucarAutopartesAplicacionWeb.Models.Sales
{
    public class LegalCustomer : Customer
    {
        [Required(ErrorMessage = "¡Ingresa la razón social!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Razón Social")]
        public string? BusinessName { get; set; }
        
        [Required(ErrorMessage = "¡Ingresa el NIT!")]
        [MaxLength(9)]
        [RegularExpression("^[0-9]{1,9}$")]
        [DisplayName("NIT")]
        public string? NIT { get; set; }
    }
}
