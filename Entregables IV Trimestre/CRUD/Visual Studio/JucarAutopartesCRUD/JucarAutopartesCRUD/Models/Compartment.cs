using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Compartment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompartmentID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(3), RegularExpression("^[0-9]+$")]
        public string? CompartmentNumber { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50)]
        public string? ProductType { get; set; }
    }
}
