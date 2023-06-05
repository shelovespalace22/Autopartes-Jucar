using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Subcategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubcategoryID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(30)]
        [DisplayName("Nombre")]
        public string SubcategoryName { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; } = true;

        [Required]
        [DisplayName("FechaDeCreación")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("FechaDeModificación")]
        public DateTime ModificationDate { get; set; }

        //Otros atributos 

        [Required]
        [DisplayName("Categoria")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "¡Escoga una Categoria!")]
        public Category Category { get; set; }

        //Constructor

        public Subcategory()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
            State = true;
        }

        //Relación con AutoPart

        public ICollection<AutoPart>? AutoParts { get; set; }

    }
}
