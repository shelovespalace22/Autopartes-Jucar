using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Warehouse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WarehouseID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un nombre!"), StringLength(50, MinimumLength = 8, ErrorMessage = "¡El nombre debe cumplir con el rango de cáracteres asignado (8-50)!")]
        public string? Name { get; set; }

        [Required]
        public bool State { get; set; } = true;
    }
}
