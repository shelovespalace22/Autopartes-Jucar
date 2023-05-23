using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class AutoPartMeasurements
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoPartMeasurementsID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), Range(1, 100, ErrorMessage = "¡Ingrese un valor entre el rango de 1-100 centimetros!")]
        public int Height { get; set; }

        [Required(ErrorMessage = "¡Ingresa un valor!"), Range(1, 100, ErrorMessage = "¡Ingrese un valor entre el rango de 1-100 centimetros!")]
        public int Length { get; set; }

        [Required(ErrorMessage = "¡Describa la unidad de medida!")]
        public string? UnitMeasurement { get; set; } = "cm";

    }
}
