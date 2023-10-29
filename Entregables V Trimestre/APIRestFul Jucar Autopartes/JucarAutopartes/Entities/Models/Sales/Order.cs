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

        /* Se eliminó propiedad 'Place' */

        [Required(ErrorMessage = "Ingrese el nombre del solicitante del pedido.")]
        [StringLength(50)]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$")]
        [DisplayName("Nombre - Razón Social")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Ingrese el correo del solicitante del pedido.")]
        [StringLength(50)]
        [EmailAddress]
        [DisplayName("Correo")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Ingrese el número telefonico del solicitante del pedido.")]
        [MaxLength(10)]
        [RegularExpression("^[0-9]+$")]
        [Phone]
        [DisplayName("Número")]
        public string? PhoneNumber { get; set; }

        [MaxLength(50)]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$")]
        [DisplayName("Dirección de Destino")]
        public string? Address { get; set; }

        [MaxLength(20)]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$")]
        [DisplayName("Estado")]
        public string? State { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor 

        public Order()
        {
            Address = "Sin dirección indicada";
            State = "Sin Contribuciones";
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Customer

        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; }

        //OrderDetail

        public ICollection<OrderDetail>? OrderDetails { get; set; }

        //Contribution

        public ICollection<Contribution>? Contributions { get; set; }

    }
}
