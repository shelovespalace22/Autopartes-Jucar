using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace JucarAutopartesWebApplication.Models.User
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Ingrese su primer/único nombre.")] 
        [StringLength(40)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Primer Nombre")]
        public string FirstName { get; set; }

        [StringLength(40)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Segundo Nombre")]
        public string? SecondName { get; set; }

        [Required(ErrorMessage = "Ingrese su primer/único apellido.")]
        [StringLength(40)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Primer Apellido")]
        public string FirstSurname { get; set; }

        [StringLength(40)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Segundo Apellido")]
        public string? SecondSurname { get; set; }

        [Required(ErrorMessage = "Ingrese su dirección de correo electrónico.")] 
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Ingrese una cuenta de correo válida.")]
        [DisplayName("Email")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Ingrese su sexo 'Masculino' o 'Femenino'.")]
        [StringLength(9)]
        [DisplayName("Sexo")]
        public SexType Sex { get; set; }

        [Required(ErrorMessage = "Escoga su fecha de nacimiento.")]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime BirthDate { get; set; }

        [Required]
        public bool State { get; set; }

        //Constructor
        public User()
        {
            State = true;
        }

        //Enumeradores

        public enum SexType
        {
            Masculino,
            Femenino
        }

        //Relaciones con otros modelos

        public ICollection<UserPhone> PhoneNumbers { get; set; }
        public ICollection<UserPosition> UserPositions { get; set; }

    }
}
