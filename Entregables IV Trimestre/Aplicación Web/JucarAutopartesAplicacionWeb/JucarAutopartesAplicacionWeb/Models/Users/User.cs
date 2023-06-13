using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JucarAutopartesAplicacionWeb.Models.Enums;
using JucarAutopartesAplicacionWeb.Models.Sales;
using Microsoft.AspNetCore.Identity;

namespace JucarAutopartesAplicacionWeb.Models.Users
{
    [Table("Users")]
    public class User : IdentityUser
    {

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int UserID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el tipo de documento!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Tipo Documento")]
        public DocumentType DocumentType { get; set; }

        [Required(ErrorMessage = "¡Ingrese el número de documento!")]
        [MaxLength(10)]
        [RegularExpression("^\\d{1,10}$")]
        [DisplayName("Documento")]
        public string? DocumentNumber { get; set; }

        [Required(ErrorMessage = "¡Ingrese el primer nombre!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Primer Nombre")]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Segundo Nombre")]
        public string? SecondName { get; set; }

        [Required(ErrorMessage = "¡Ingrese el primer apellido!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Primer Apellido")]
        public string? FirstSurname { get; set; }

        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("SegundoApellido")]
        public string? SecondSurname { get; set; }

        [Required(ErrorMessage = "¡Escoga una de las opciones!")]
        [MaxLength(10)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Sexo")]
        public SexType Sex { get; set; }

        [Required(ErrorMessage = "¡Seleccione su fecha de cumpleaños!")]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "¡Ingrese el lugar de nacimiento!")]
        [MaxLength(100)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Lugar de Nacimiento")]
        public string? BirthCity { get; set; }

        [Required(ErrorMessage = "¡Ingrese la ciudad de residencia!")]
        [MaxLength(100)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Ciudad de Residencia")]
        public string? CityResidence { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; }

        [Required]
        [DisplayName("Creación de Registro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación de Registro")]
        public DateTime ModificationDate { get; set; }

        //Constructor
        public User()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //UserPhone

        public ICollection<UserPhone> UserPhones { get; set; }

        //UserPosition

        public ICollection<UserPosition> UserPositions { get; set; }

        //UserAddress

        public ICollection<UserAddress> UserAddresses { get; set; }

        //Bill 

        public ICollection<Bill> Bills { get; set; }
    }

}

