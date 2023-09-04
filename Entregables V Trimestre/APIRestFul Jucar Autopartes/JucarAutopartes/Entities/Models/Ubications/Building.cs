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
    public class Building
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BuildingID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el tipo del edificio!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Tipo de Edificio")]
        public string? BuildingType { get; set; }

        [Required(ErrorMessage = "¡Ingresa el número del edificio!")]
        [MaxLength(4)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Número del Edificio")]
        public string? BuildingNumber { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }


        //Constructor

        public Building()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        public ICollection<Address> Addresses { get; set; }
    }
}
