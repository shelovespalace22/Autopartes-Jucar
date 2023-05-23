using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Discount
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiscountID { get; set; }

        [Required(ErrorMessage = "¡El campo es requerido!"), Range(0.01, 0.5, ErrorMessage = "El descuento del producto debe estar entre 1% y 50% máximo")]
        public double DiscountRate { get; set; }

        [Required(ErrorMessage = "¡Digite una fecha de inicio!")]
        public DateTime InitialDiscountDate { get; set; }

        [Required(ErrorMessage = "¡Digite una fecha de terminación!")]
        public DateTime FinalDiscountDate { get; set; }

        [Required]
        public bool State { get; set; } = true;

        
    }
}
