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
    public class Contribution
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ContributionID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el monto aportado!")]
        [MaxLength(5)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Monto del Aporte")]
        public decimal AmountPaid { get; set; }

        [Required]
        [DisplayName("Fecha del Aporte")]
        public DateTime ContributionDate { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public Contribution()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //PaymentMethod

        public Guid PaymentMethodId { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }

        //Order

        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
