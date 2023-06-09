﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace JucarAutopartesAplicacionWeb.Models.Factories
{
    public class FactoryPhone
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FactoryPhoneID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el tipo de teléfono!")]
        [DisplayName("Tipo de Teléfono")]
        public string? PhoneType { get; set; }

        [Required(ErrorMessage = "¡Ingrese el número de teléfono!")]
        [DisplayName("Número de Teléfono")]
        public string? PhoneNumber { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public FactoryPhone()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        public int FactoryID { get; set; }
        public Factory? Factory { get; set; }
    }
}
