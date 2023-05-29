using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Stock
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(3), RegularExpression("^[0-9]+$")]
        public string? QuantityAvailable { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(3), RegularExpression("^[0-9]+$")]
        public string? InitialStocks { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(3), RegularExpression("^[0-9]+$")]
        public string? ReorderPoint { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(3), RegularExpression("^[0-9]+$")]
        public string? MinimumInventory { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(3), RegularExpression("^[0-9]+$")]
        public string? MaximumInventory { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime ModificationDate { get; set; }

    }
}
