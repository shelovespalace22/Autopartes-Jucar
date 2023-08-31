using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesAplicacionWeb.Models.Sales
{
    public class WayToPay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WayToPayID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el nombre!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Nombre Forma de Pago")]
        public string? WayToPayName { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public WayToPay()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        public int BillID { get; set; }
        public Bill? Bill { get; set; }
    }
}
