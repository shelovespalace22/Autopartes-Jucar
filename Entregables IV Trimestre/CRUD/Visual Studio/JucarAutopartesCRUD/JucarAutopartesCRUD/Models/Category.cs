using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(30)]
        [DisplayName("Nombre")]
        public string? CategoryName { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; } = true;

        [Required]
        [DisplayName("FechaDeCreación")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("FechaDeModificación")]
        public DateTime ModificationDate { get; set; }

        //Contsructor

        public Category()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
            State = true;
        }



        //Relación con Subcategory
        public ICollection<Subcategory>? Subcategories { get; set; }
    }
}
