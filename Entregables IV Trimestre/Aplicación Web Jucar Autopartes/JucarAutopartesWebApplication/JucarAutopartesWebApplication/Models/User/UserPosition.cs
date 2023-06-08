using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesWebApplication.Models.User
{
    public class UserPosition
    {
        [Key]
        [Column(Order = 0)]
        public int UserId { get; set; }
        public User User { get; set; }

        [Key]
        [Column(Order = 1)]
        public int PositionID { get; set; }
        public Position Position { get; set; }
    }
}
