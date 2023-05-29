using System.ComponentModel.DataAnnotations;

namespace JucarAutopartesCRUD.Models
{
    public class LegalProvider : Provider
    {
        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50)]
        public string? BussinesName { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(9)]
        public string? NIT { get; set; }
    }
}
