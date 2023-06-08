using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JucarAutopartesWebApplication.Models.User;

namespace JucarAutopartesWebApplication.Models
{
    public class Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PositionID { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del cargo.")]
        [StringLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Nombre Cargo")]
        public string PositionName { get; set; }
        
        [Required]
        public bool State { get; set; }

        //Constructor

        public Position()
        {
            State = true;
        }

        //Relaciones con otros modelos

        public ICollection<UserPosition> UserPositions { get; set; }
    }
}
