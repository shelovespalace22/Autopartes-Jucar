using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace JucarAutopartesCRUD.Models
{
    public class Stock
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), Range(1,500, ErrorMessage = "¡Ingrese un valor entre el rango permitido (1-500)!")]
        public int AmountStock { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!")]
        public int InitialStocks { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!")]
        public int MaxInventory { get; set; } = 10;

        [Required(ErrorMessage = "¡Ingrese un valor!")]
        public int MinInventory { get; set; } = 500;

        
    }
}
