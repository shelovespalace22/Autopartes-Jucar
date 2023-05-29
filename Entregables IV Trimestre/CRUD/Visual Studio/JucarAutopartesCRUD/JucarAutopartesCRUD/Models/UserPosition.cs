using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesCRUD.Models
{
    public class UserPosition
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserPositionID { get; set; }
    }
}
