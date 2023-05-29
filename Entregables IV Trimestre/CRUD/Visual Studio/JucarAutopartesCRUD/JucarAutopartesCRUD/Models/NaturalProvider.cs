using System.ComponentModel.DataAnnotations;

namespace JucarAutopartesCRUD.Models
{
    public class NaturalProvider : Provider
    {
        [Required(ErrorMessage = "¡Ingresa un valor!"), StringLength(5)]
        public string? DocumentType { get; set; }
        
        [Required(ErrorMessage = "¡Ingresa un valor!"), StringLength(10)]
        public string? DocumentNumber { get; set; }

        [Required(ErrorMessage = "¡Ingresa un valor!"), StringLength(50)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "¡Ingresa un valor!"), StringLength(50)]
        public string? SecondName { get; set; }

        [Required(ErrorMessage = "¡Ingresa un valor!"), StringLength(50)]
        public string? LastName { get; set; }

    }
}
