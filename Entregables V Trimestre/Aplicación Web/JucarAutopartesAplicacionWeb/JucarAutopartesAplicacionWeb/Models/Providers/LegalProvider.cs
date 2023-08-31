using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JucarAutopartesAplicacionWeb.Models.Providers
{
    public class LegalProvider : Provider
    {
        [Required(ErrorMessage = "¡Ingresa la razón social!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Razón Social")]
        public string? BusinessName { get; set; }

        [Required(ErrorMessage = "¡Ingresa el NIT!")]
        [MaxLength(9)]
        [RegularExpression("^\\d{1,9}$")]
        [DisplayName("NIT")]
        public string? NIT { get; set; }

        [Required(ErrorMessage = "¡Ingresa el representante legal")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Representante Legal")]
        public string? LegalRepresentative { get; set; }

    }
}
