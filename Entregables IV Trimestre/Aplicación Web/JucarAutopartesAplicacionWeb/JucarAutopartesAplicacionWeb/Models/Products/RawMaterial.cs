﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesAplicacionWeb.Models.Products
{
    public class RawMaterial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RawMaterialID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el nombre de la Materia Prima!")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\\s]+$", ErrorMessage = "¡Ingrese un nombre válido!")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "¡Ingrese el tipo de la Materia Prima!")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\\s]+$", ErrorMessage = "¡Ingrese un tipo válido!")]
        [DisplayName("Tipo")]
        public string? Type { get; set; }

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

        public RawMaterial()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //AutopartMaterial

        public ICollection<AutopartMaterial>? AutopartMaterials { get; set; }

        //Stock

        public ICollection<Stock>? Stocks { get; set; }

        //Movement

        public ICollection<Movement>? Movements { get; set; }


    }
}
