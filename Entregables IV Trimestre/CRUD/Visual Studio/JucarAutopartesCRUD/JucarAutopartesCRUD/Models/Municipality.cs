using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Municipality
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MunicipalityID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50), RegularExpression("^[a-zA-Z]+$")]
        public string? Name { get; set; }

        [Required]
        public bool Capital { get; set; } = false;
    }
}
