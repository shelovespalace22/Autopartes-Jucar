using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class BillDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillDetailID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(2), RegularExpression("^[0-9]+$")]
        public string? ItemNumber { get; set; }

        [Required(ErrorMessage = "¡Ingresa un valor!"), StringLength(2), RegularExpression("^[0-9]+$")]
        public string? Quantity { get; set; }
    }
}
