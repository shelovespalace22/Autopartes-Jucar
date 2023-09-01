using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Products
{
    public class Subcategory
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SubcategoryID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un nombre para la subcategoría!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; }

        [Required]
        [DisplayName("Creación del Registro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Registro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public Subcategory()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Category
        [ForeignKey(nameof(Category))]
        public Guid CategoryID { get; set; }

        [DisplayName("Categoría")]
        public Category? Category { get; set; }

        //Autopart
        public ICollection<Autopart>? Autoparts { get; set; }
    }
}
