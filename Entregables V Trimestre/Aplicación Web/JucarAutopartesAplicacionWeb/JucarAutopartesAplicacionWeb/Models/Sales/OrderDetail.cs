using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JucarAutopartesAplicacionWeb.Models.Products;

namespace JucarAutopartesAplicacionWeb.Models.Sales
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el producto solicitado!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Producto")]
        public string? Product { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad solicitada!")]
        [MaxLength(5)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Cantidad")]
        public string? Quantity { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public OrderDetail()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Autopart

        public int AutopartID { get; set; }
        public Autopart? Autopart { get; set; }

        //OrderDetail

        public int OrderID { get; set; }
        public Order? Order { get; set; }
    }
}
