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

        [Required(ErrorMessage = "¡Describa la función de la autoparte!"), StringLength(200)]
        public string? Performance { get; set; }

        [Required(ErrorMessage = "¡Ingrese el peso de la autoparte!"), StringLength(3)]
        public string? WeightKgs { get; set; }

        [Required(ErrorMessage = "¡Ingrese la altura de la autoparte!"), StringLength(3)]
        public string? HeightCms { get; set; }

        [Required(ErrorMessage = "¡Ingrese el largo de la autoparte!"), StringLength(3)]
        public string? LenghtCms { get; set; }

        [Required(ErrorMessage = "¡Describa la zona a la que pertenece la autoparte!"), StringLength(50)]
        public string? VehicleZone { get; set; }

        [Required]
        public bool State { get; set; } = true;

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime ModificationDate { get; set; }

        //ATRIBUTOS NUEVOS





        //otros atributos 

        public int SubcategoryID { get; set; }

        public Subcategory? Subcategory { get; set; }

        //Relaciones

        public ICollection<AutoPartMaterial> autoPartMaterials { get; set; }
        

    }
}
