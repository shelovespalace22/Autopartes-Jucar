using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class OrderDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50), RegularExpression("^[a-zA-Z]+$")]
        public string? Product { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), RegularExpression("^[0-9]+$")]
        public string? Quantity { get; set; }
    }
}
