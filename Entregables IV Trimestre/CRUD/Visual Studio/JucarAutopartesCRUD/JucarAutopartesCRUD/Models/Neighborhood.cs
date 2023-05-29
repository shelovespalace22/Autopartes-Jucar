using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Neighborhood
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NeighborhoodID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50), RegularExpression("^[a-zA-Z]+$")]
        public string? Name { get; set; }
    }
}
