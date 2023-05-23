using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class AutoPart
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int AutoPartID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un nombre!"), StringLength(50)]
        public string? Name { get; set; }

        [/*Required(ErrorMessage = "¡Describa la función de la autoparte!"), */StringLength(200)]
        public string? Function { get; set; }

        [Required(ErrorMessage = "¡Describa la zona a la que pertenece la autoparte!"), StringLength(50)]
        public string? VehicleZone { get; set; }

        [Required]
        public bool State { get; set; } = true;

        //otros atributos 

        public int SubcategoryID { get; set; }

        public Subcategory? Subcategory { get; set; }

    }
}
