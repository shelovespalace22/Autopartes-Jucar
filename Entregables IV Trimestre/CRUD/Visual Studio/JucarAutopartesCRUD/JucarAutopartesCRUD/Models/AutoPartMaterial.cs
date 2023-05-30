using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class AutoPartMaterial
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoPartMaterialID { get; set; }

        [Required(ErrorMessage = "¡Describa la composición de la autoparte!"), StringLength(100)]
        public string? AutoPartComposition { get; set; }

        //Relación de 1:N desde AutoPart 
        public int AutopartID { get; set; } //FK
        public AutoPart? AutoPart { get; set; }

        //Relación de 1:N desde RawMaterial
        public int RawMaterialID { get; set; } //FK
        public RawMaterial? RawMaterial { get; set; }
    }
}
