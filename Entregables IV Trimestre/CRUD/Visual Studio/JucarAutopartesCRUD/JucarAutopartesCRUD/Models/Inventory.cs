using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace JucarAutopartesCRUD.Models
{
    public class Inventory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), Range(1,500, ErrorMessage = "¡Ingrese un valor entre el rango permitido (1-500)!"), RegularExpression("^[0-9]+$")]
        public int QuantityAvailable { get; set; }

        [Required(ErrorMessage = "¡Ingrese una fecha!")]
        public DateTime LastUpdateDate { get; set; }



    }
}
