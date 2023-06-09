﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesAplicacionWeb.Models.Users
{
    public class UserPosition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int UserPositionID { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }


        //Constructor

        public UserPosition()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //User
        //public int UserID { get; set; }
        public User? User { get; set; }

        //Position
        public int PositionID { get; set; }
        public Position? Position { get; set; }
    }
}
