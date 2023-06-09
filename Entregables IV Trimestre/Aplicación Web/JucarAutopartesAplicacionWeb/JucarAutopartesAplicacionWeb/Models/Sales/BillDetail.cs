﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JucarAutopartesAplicacionWeb.Models.Products;

namespace JucarAutopartesAplicacionWeb.Models.Sales
{
    public class BillDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillDetailID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el número del item!")]
        [MaxLength(2)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Item")]
        public string? ItemNumber { get; set; }

        [Required(ErrorMessage = "¡Ingresa la cantidad del item!")]
        [MaxLength(5)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Cantidad")]
        public string? Quantity { get; set; }

        [Required(ErrorMessage = "¡Ingresa el valor unitario del item!")]
        [MaxLength(10)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Valor Unitario")]
        public double UnitValue { get; set; }

        [Required(ErrorMessage = "¡Ingresa la tarifa de IVA!")]
        [MaxLength(2)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Tarifa IVA")]
        public double IVA { get; set; }

        [Required(ErrorMessage = "¡Ingresa el valor subtotal!")]
        [MaxLength(10)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Subtotal")]
        public double SubtotalValue { get; set; }

        [Required(ErrorMessage = "¡Ingresa el valor total!")]
        [MaxLength(10)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Total")]
        public double TotalValue { get; set; }
        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public BillDetail()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Autopart
        public int AutopartID { get; set; }
        public Autopart? Autopart { get; set; }

        //Bill

        public int BillID { get; set; }
        public Bill? Bill { get; set; }
    }
}
