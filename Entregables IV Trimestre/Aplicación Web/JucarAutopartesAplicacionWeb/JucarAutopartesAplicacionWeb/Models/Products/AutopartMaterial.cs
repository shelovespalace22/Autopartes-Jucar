using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JucarAutopartesAplicacionWeb.Models.Products;

namespace JucarAutopartesAplicacionWeb.Models.Products
{
    public class AutopartMaterial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutopartMaterialID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el material principal de la autoparte!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Material Principal")]
        public string? MainMaterial { get; set; }

        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Material Secundario")]
        public string? SecondaryMaterial { get; set; }

        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Otro Material")]
        public string? OtherMaterial { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor 

        public AutopartMaterial()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //Autopart 

        public int AutopartID{ get; set; }
        public Autopart? Autopart { get; set; }

        //RawMaterial

        public int RawMaterialID { get; set; }
        public RawMaterial? RawMaterial { get; set; }
    }
}
