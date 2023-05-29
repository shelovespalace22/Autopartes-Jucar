using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Provider
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProviderID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50)]
        public string? ProductType { get; set; }

        [Required]
        public bool State { get; set; } = true;
    }
}
