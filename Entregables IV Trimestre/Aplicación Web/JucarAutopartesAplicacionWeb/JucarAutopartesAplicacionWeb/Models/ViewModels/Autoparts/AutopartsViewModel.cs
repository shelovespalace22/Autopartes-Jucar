using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using JucarAutopartesAplicacionWeb.Models.Products;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesAplicacionWeb.Models.ViewModels.Autoparts
{
    public class AutopartsViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NewAutopartViewModelID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el nombre de la autoparte!")]
        [MaxLength(50, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[a-zA-Z0-9\\s]+$")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Escoga una subcategoría.")]
        [DisplayName("Subcategoría")]
        public Subcategory? Subcategory { get; set; }

        [Required(ErrorMessage = "¡Ingrese una descripción para la autoparte!")]
        [MaxLength(200, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Descripción")]
        public string? Description { get; set; }

        [MaxLength(3, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Peso Kgs")]
        public string? WeightKgs { get; set; }

        [MaxLength(3, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Altura Cm")]
        public string? HeightCm { get; set; }

        [MaxLength(3, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Largo Cm")]
        public string? LengthCm { get; set; }

        [Required(ErrorMessage = "¡Ingrese la zona del vehículo a la que pertenece!")]
        [MaxLength(50, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Zona del Vehículo")]
        public string? VehicleZone { get; set; }

        [Required(ErrorMessage = "¡Seleccione el material principal de la autoparte!")]
        [DisplayName("Material Principal")]
        public RawMaterial? MainMaterial { get; set; }

        [DisplayName("Material Secundario")]
        public RawMaterial? SecondaryMaterial { get; set; }

        [DisplayName("Otro Material")]
        public RawMaterial? Other { get; set; }

        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Cantidad Disponible")]
        public string? QuantityAvailable { get; set; }

        [Required(ErrorMessage = "¡Ingrese el valor de la autoparte!")]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Valor")]
        public double Value { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor 

        public AutopartsViewModel()
        {
            Name = "Sin nombre";
            Description = "Sin descripción";
            WeightKgs = "0";
            HeightCm = "0";
            LengthCm = "0";
            VehicleZone = "Sin Zona";
            //MainMaterial = "Sin Material";
            //SecondaryMaterial = "Sin Material";
            //Other = "Sin Material";
            QuantityAvailable = "0";
            Value = 0;
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }
    }
}
