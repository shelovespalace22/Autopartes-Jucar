using Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Sales
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderDetailID { get; set; }

        [Required(ErrorMessage = "¡Ingresa la cantidad del item!")]
        [MaxLength(5)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Cantidad")]
        public string? Quantity { get; set; }

        [Required(ErrorMessage = "¡Ingresa el valor unitario del item!")]
        [MaxLength(10)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Valor Unitario")]
        public decimal UnitValue { get; set; }

        [Required(ErrorMessage = "¡Ingresa el valor subtotal!")]
        [MaxLength(10)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Subtotal")]
        public decimal SubtotalValue { get; set; }

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

        public Guid AutopartId { get; set; }
        public Autopart? Autopart { get; set; }

        //OrderDetail

        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
