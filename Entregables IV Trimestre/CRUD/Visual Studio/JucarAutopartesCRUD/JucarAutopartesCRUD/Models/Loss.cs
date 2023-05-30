using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Loss
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LossID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), Range(1, 1000, ErrorMessage = "¡El valor debe estar entre el rango permitido (1-1000)!"), RegularExpression("^[0-9]+$")]
        public int AmountLoss { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(30)]
        public string? Responsible { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50)]
        public string? Place { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(100)]
        public string? Reason { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!")]
        public DateTime DateLoss { get; set; }

        //Relación de 1:N desde AutoPart
        public int AutoPartID { get; set; } //FK
        public AutoPart? AutoPart { get; set; }

    }
}
