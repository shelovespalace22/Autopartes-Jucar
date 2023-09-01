using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Users;

namespace Entities.Models.Sales
{
    public class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el número de factura de venta!")]
        [MaxLength(5)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Número Factura de Venta")]
        public string? SalesInvoiceNumber { get; set; }

        [Required(ErrorMessage = "¡Ingrese el nombre del cliente!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Cliente")]
        public string? Customer { get; set; }

        [MaxLength(50)]
        [RegularExpression("^\\d{1,10}$")]
        [DisplayName("Número de Documento")]
        public string? DocumentNumber { get; set; }

        [MaxLength(50)]
        [RegularExpression("^\\d{1,9}$")]
        [DisplayName("Número NIT")]
        public string? NIT { get; set; }

        [Required(ErrorMessage = "¡Ingresa el número teléfonico del cliente!")]
        [MaxLength(10)]
        [RegularExpression("^\\d{1,10}$")]
        [Phone]
        [DisplayName("Número Teléfonico")]
        public string? CustomerPhone { get; set; }

        [MaxLength(150)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Observación")]
        public string? Observation { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public Bill()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //Order

        public int OrderID { get; set; }
        public Order? Order { get; set; }

        //BillDetail

        public ICollection<BillDetail> BillDetails { get; set; }

        //WayToPay

        public WayToPay? WayToPay { get; set; }

        //User

        //public int UserID { get; set; }
        public User? User { get; set; }
    }
}
