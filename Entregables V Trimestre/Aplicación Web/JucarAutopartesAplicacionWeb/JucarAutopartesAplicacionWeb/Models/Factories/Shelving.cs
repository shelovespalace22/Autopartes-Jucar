using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using JucarAutopartesAplicacionWeb.Models.Products;

namespace JucarAutopartesAplicacionWeb.Models.Factories
{
    public class Shelving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShelvingID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el número de la estanteria!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Número de Estanteria")]
        public string? ShelvingNumber { get; set; }

        [Required(ErrorMessage = "¡Ingrese el tipo de producto!")]
        [MaxLength(20)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Tipo de Producto")]
        public string? ProductType { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public Shelving()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Inventory 

        public int InventoryID { get; set; }
        public Inventory? Inventory { get; set; }

        //Shelf

        public int ShelfID { get; set; }
        public Shelf? Shelf { get; set; }

    }
}
