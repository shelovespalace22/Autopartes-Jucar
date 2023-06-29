using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JucarAutopartesAplicacionWeb.Models.Enums;

namespace JucarAutopartesAplicacionWeb.Models.Users
{
    public class UserPhone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserPhoneID { get; set; }

        [Required(ErrorMessage = "¡Escoga una opción de tipo de teléfono!")]
        [DisplayName("Tipo Teléfono")]
        public string? PhoneType { get; set; }

        [Required(ErrorMessage = "¡Ingrese el número teléfonico!")]
        [DisplayName("Numero Teléfono")]
        public string? PhoneNumber { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }


        //Constructor

        public UserPhone()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }


        //Relaciones con otros modelos 

        public string? UserID { get; set; }
        public User? User { get; set; }

    }
}
