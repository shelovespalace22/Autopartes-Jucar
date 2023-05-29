using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class Contribution
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContributionID { get; set; }

        [Required]
        public DateTime ContributionDate { get; set; }

        [Required(ErrorMessage = "¡Ingresa un valor!")]
        public double Value { get; set; }
    }
}
