using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Factory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FactoryID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el NIT!"), StringLength(9, ErrorMessage = "El limite de dígitos es de 9"), RegularExpression("^[0-9]+$")]
        public string? NIT { get; set; }

        [Required(ErrorMessage = "¡Ingresa la razón social!"), StringLength(50, ErrorMessage = "El limite de caracteres es de 50")]
        public string? BusinessName { get; set; }

        [Required(ErrorMessage = "¡Ingresa la dirección de email!"), EmailAddress(ErrorMessage = "¡Ingresa una dirección de correo electrónico!"), RegularExpression("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$")]
        public string? EmailAddress { get; set; }
    }
}
