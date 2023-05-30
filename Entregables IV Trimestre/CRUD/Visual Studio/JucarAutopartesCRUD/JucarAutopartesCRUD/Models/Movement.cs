using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JucarAutopartesCRUD.Models.Enums;

namespace JucarAutopartesCRUD.Models
{
    public class Movement
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovementID { get; set; }

        [Required(ErrorMessage = "¡Describa el tipo de movimiento!"), StringLength(50)]
        public MovementType MovementType { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad del movimiento!"), RegularExpression("^[0-9]+$")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "¡Ingrese una fecha!")]
        public DateTime MovementDate { get; set; }

        //Relación de 1:N desde RawMaterial
        public int RawMaterialID { get; set; }
        public RawMaterial? RawMaterial { get; set; }
    }
}
