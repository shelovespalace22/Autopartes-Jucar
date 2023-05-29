using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Subcategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubcategoryID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(30)]
        public string? SubcategoryName { get; set; }

        [Required]
        public bool State { get; set; } = true;

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime ModificationDate { get; set; }

        //Otros atributos 
        public int CategoryID { get; set; }
        public Category? Category { get; set; }

        //Relación con AutoPart

        public ICollection<AutoPart>? AutoParts { get; set; }

    }
}
