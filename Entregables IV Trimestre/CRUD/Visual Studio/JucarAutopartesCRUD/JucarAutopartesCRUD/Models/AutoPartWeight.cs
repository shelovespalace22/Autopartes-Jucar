using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class AutoPartWeight
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoPartWeightID { get; set; }

        [Required (ErrorMessage = "¡Digite un peso!"), Range(1, 100, ErrorMessage = "¡Solo se permite un valor entre 1 y 100 kgs!")]
        public int Weight { get; set; }

        [Required (ErrorMessage = "¡Asigne una unidad al peso!")]
        public string? WeightUnit { get; set; } = "Kgs";
    }
}
