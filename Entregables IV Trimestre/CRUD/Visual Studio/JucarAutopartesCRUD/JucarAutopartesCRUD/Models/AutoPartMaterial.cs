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

        //Otros atributos

        public int AutopartID { get; set; }

        public AutoPart? AutoPart { get; set; }

        public int RawMaterialID { get; set; }

        public RawMaterial? RawMaterial { get; set; }
    }
}
