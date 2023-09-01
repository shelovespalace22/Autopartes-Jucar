﻿using Entities.Models.Products;
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
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderDetailID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el producto solicitado!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Producto")]
        public string? Product { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad solicitada!")]
        [MaxLength(5)]
        [RegularExpression("^\\d+$")]
        [DisplayName("Cantidad")]
        public string? Quantity { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public OrderDetail()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Autopart

        public Guid AutopartID { get; set; }
        public Autopart? Autopart { get; set; }

        //OrderDetail

        public Guid OrderID { get; set; }
        public Order? Order { get; set; }
    }
}
