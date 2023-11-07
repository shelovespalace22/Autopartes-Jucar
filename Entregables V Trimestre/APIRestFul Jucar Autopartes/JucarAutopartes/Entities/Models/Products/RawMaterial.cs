using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Products
{
    public class RawMaterial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RawMaterialID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el nombre de la Materia Prima!")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        /* Elminé la propiedad 'Type' */

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

        public RawMaterial()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        /* Métodos */

        public void setModificationDate()
        {
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        /* Elminé la relación con la clase 'AutopartMaterials' */

        //Stock

        public Stock? Stocks { get; set; }

        //Movement

        public ICollection<Movement>? Movements { get; set; }

        // Autopart

        public ICollection<Autopart>? Autopart { get; set; }
    }
}
