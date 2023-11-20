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
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderID { get; set; }

        [Required(ErrorMessage = "Ingrese la Fecha del Pedido")]
        [DisplayName("Fecha del Pedido")]
        public DateTime OrderDate { get; set; }
        //Customer
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "Escoga un Cliente")]
        [DisplayName("Cliente")]
        public Customer? Customer { get; set; }

        [DisplayName("Total de Venta")]
        public decimal? Total { get; set; }

        [MaxLength(50)]
        [DisplayName("Estado de Pago")]
        public string? PaymentStatus { get; set; }

        [MaxLength(100)]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Dirección de Envío")]
        public string? ShippingAddress { get; set; }

        [MaxLength(50)]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Estado de Envío")]
        public string? ShippingStatus { get; set; }

        [MaxLength(200)]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Observación")]
        public string? Observation { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor 

        public Order()
        {
            Total = 0;
            PaymentStatus = "Pendiente";
            ShippingAddress = "No hay dirección de envío.";
            ShippingStatus = "En Fabrica";
            Observation = "No se realizó ninguna observación.";
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        /* Métodos */

        public void setModificationDate()
        {
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //OrderDetail

        public ICollection<OrderDetail>? OrderDetails { get; set; }

        //Contribution

        public ICollection<Contribution>? Contributions { get; set; }
    }
}
