﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesAplicacionWeb.Models.Products
{
    public class PriceHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PriceHistoryID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el valor de la autoparte!")]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Valor")]
        public double Value { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public PriceHistory()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //Autopart 

        public int AutopartID { get; set; }
        public Autopart? Autopart { get; set; }

        //DiscountHistory

        public ICollection<DiscountHistory>? DiscountHistories { get; set; }

    }
}
