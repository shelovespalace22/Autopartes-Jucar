using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class RawMaterial
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RawMaterialID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el tipo de materia prima!"), StringLength(50)]
        public string? Type { get; set; }

        [Required(ErrorMessage = "¡Ingrese un nombre!"), StringLength(50)]
        public string? Name { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime ModificationDate { get; set; }
    }
}
