using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JucarAutopartesCRUD.Models.Enums;

namespace JucarAutopartesCRUD.Models
{
    public class Street
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StreetID { get; set; }

        [Required(ErrorMessage = "¡Escoga una de las opciones!"), StringLength(20)]
        public StreetType StreetType { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(3), RegularExpression("^[0-9]+$")]
        public string? StreetNumber { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(3), RegularExpression("^[a-zA-Z]+$")]
        public string? Suffix { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(3), RegularExpression("^[0-9]+$")]
        public string? FirstNumber { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(3), RegularExpression("^[0-9]+$")]
        public string? SecondNumber { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime ModificationDate { get; set; }


    }
}
