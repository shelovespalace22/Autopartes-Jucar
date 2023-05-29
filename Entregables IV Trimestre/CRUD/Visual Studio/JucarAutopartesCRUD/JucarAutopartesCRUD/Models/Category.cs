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
        public string? CategoryName { get; set; }

        [Required]
        public bool State { get; set; } = true;

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime ModificationDate { get; set; }



        //Relación con Subcategory
        public ICollection<Subcategory>? Subcategories { get; set; }
    }
}
