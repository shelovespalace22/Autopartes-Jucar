using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Price
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PriceID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), Range(100.0, 100000.0, ErrorMessage = "¡El valor ingresado debe estar entre el rango permitido (100, 100.000!")]
        public double Value { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!")]
        public DateTime InitialDate { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!")]
        public DateTime FinalDate { get; set; }

        [Required]
        public bool State { get; set; } = true;
    }
}
