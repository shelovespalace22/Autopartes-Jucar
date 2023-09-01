using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Ubications
{
    public class Street
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StreetID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el tipo de calle!")]
        [DisplayName("Tipo de Calle")]
        public string? StreetType { get; set; }

        [Required(ErrorMessage = "¡Ingresa el número de calle!")]
        [MaxLength(5)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Numero de Calle")]
        public string? StreetNumber { get; set; }

        [MaxLength(10)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Sufijo")]
        public string? Sufix { get; set; }

        [Required(ErrorMessage = "¡Ingresa un número!")]
        [MaxLength(5)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Número")]
        public string? FirstNumber { get; set; }

        [Required(ErrorMessage = "¡Ingresa un número!")]
        [MaxLength(5)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Número")]
        public string? SecondNumber { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public Street()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Neighborhood

        public Guid NeighborhoodID { get; set; }
        public Neighborhood? Neighborhood { get; set; }

        //Address
        public ICollection<Address> Addresses { get; set; }
    }
}
