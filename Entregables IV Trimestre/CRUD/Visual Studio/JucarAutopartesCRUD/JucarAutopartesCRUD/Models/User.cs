using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(40)]
        public string? FirstName { get; set; }

        [StringLength(40)]
        public string? SecondName { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(40)]
        public string? FirstSurname { get; set; }

        [StringLength(40)]
        public string? SecondSurname { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(30)]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(30)]
        public string? HomeAddress { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(1)]
        public string? Sex { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!") ]
        public DateTime BirthDate { get; set; }

        [Required]
        public bool State { get; set; } = true;
    }
}
