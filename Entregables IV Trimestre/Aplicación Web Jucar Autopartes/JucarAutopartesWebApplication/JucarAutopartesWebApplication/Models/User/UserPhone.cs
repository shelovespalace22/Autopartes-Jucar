using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesWebApplication.Models.User
{
    public class UserPhone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserPhoneID { get; set; }

        [Required(ErrorMessage = "Escoga el tipo de número teléfonico.")]
        [DisplayName("Tipo Teléfono")]
        public PhoneType Type { get; set; }

        [Required(ErrorMessage = "Ingrese un número teléfonico.")]
        [Phone(ErrorMessage = "Ingrese un número teléfonico válido. Ejm: 9013295 o 3192627425")]
        [RegularExpression("^[0-9]{7,10}$")]
        [DisplayName("Número Teléfono")]
        public string PhoneNumber { get; set; }

        //Constructor


        //Enumeradores

        public enum PhoneType
        {
            Fijo,
            Celular,
            Hogar,
            Empresa,
            Oficina
        }

        //Relaciones con otros modelos
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
