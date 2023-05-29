using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Shelf
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShelfID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el material del estante!"), StringLength(30)]
        public string? Material { get; set; }

        [Required(ErrorMessage = "¡Ingresa el color del estante!"), StringLength(30)]
        public string? Color { get; set; }

        [Required(ErrorMessage = "¡Ingrese la altura del estante!"), StringLength(3), RegularExpression("^[0-9]+$"), Range(1, 300)]
        public int HeightCms { get; set; }

        [Required(ErrorMessage = "¡Ingrese el largo del estante!"), StringLength(3), RegularExpression("^[0-9]+$"), Range(1, 300)]
        public int LenghtCms { get; set; }

        [Required(ErrorMessage = "¡Ingresa la capacidad máxima del estante!"), RegularExpression("^[0-9]+$"), Range(50, 200)]
        public string? MaxCapacityKgs { get; set; }
    }
}
