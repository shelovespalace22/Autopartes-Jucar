using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class DiscountHistory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiscountHistoryID { get; set; }

        [Required(ErrorMessage = "¡El campo es requerido!"), Range(0.01, 0.5, ErrorMessage = "El descuento del producto debe estar entre 1% y 50% máximo"), RegularExpression("^[0-9]+$")]
        public double DiscountRate { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!")]
        public double TemporalValue { get; set; }

        [Required(ErrorMessage = "¡Digite una fecha de inicio!")]
        public DateTime InitialDiscountDate { get; set; }

        [Required(ErrorMessage = "¡Digite una fecha de terminación!")]
        public DateTime FinalDiscountDate { get; set; }

        [Required]
        public bool State { get; set; } = true;

        //Relación de 1:N desde PriceHistory
        public int PriceHistoryID { get; set; }
        public PriceHistory? PriceHistory { get; set; }

    }
}
