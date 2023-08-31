using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesAplicacionWeb.Models.Ubications
{
    public class Municipality
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MunicipalityID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el nombre del municipio!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        [Required]
        [DisplayName("Capital")]
        public bool Capital { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public Municipality()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Department

        public int DepartmentID { get; set; }
        public Department? Department { get; set; }

        //Neighborhood

        public ICollection<Neighborhood> Neighborhoods { get; set; }
    }
}
