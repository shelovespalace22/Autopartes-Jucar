﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Products
{
    public class DiscountHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DiscountHistoryID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el porcentaje de descuento!")]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Porcentaje de Descuento")]
        public double DiscountRate { get; set; }

        [Required(ErrorMessage = "¡Ingrese el valor temporal!")]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Valor Temporal")]
        public double TemporalValue { get; set; }

        [Required(ErrorMessage = "¡Ingrese la fecha inicial de descuento!")]
        [DisplayName("Fecha Inicial")]
        public DateTime InitialDiscountDate { get; set; }

        [Required(ErrorMessage = "¡Ingrese la fecha final de descuento!")]
        [DisplayName("Fecha Final")]
        public DateTime FinalDiscountDate { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool State { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        public DiscountHistory()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        public Guid PriceHistoryID { get; set; }
        public PriceHistory? PriceHistory { get; set; }
    }
}
