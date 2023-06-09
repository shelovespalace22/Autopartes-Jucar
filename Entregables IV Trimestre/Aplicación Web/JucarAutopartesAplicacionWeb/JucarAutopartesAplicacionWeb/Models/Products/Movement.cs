﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace JucarAutopartesAplicacionWeb.Models.Products
{
    public class Movement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovementID { get; set; }

        [Required(ErrorMessage = "¡Ingrese la cantidad del movimiento!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Cantidad")]
        public string? Quantity { get; set; }

        [Required]
        [MaxLength(20)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Tipo de Movimiento")]
        public string? MovementType { get; set; }

        [Required(ErrorMessage = "¡Ingrese la fecha del movimiento!")]
        [DisplayName("Fecha del Movimiento")]
        public DateTime MovementDate { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor 

        public Movement()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        public int RawMaterialID { get; set; }

        [DisplayName("Materia Prima")]
        public RawMaterial? RawMaterial { get; set; }


    }
}
