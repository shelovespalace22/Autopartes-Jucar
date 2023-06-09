﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace JucarAutopartesAplicacionWeb.Models.Factories
{
    public class Shelf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShelfID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el número!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Número de Estante")]
        public string? ShelfNumber { get; set; }

        [Required(ErrorMessage = "¡Ingresa el material!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Material")]
        public string? Material { get; set; }

        [Required(ErrorMessage = "¡Ingresa el color!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Color")]
        public string? Color { get; set; }

        [Required(ErrorMessage = "¡Ingresa la altura!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Altura Cm")]
        public string? HeightCm { get; set; }

        [Required(ErrorMessage = "¡Ingresa el largo!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Largo Cm")]
        public string? LengthCm { get; set; }

        [Required(ErrorMessage = "¡Ingresa la capacidad máxima!")]
        [MaxLength(3)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Capacidad Máxima Kgs")]
        public string? MaxCapacityKgs { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public Shelf()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //Shelving

        public ICollection<Shelving> Shelvings { get; set; }

        //Warehouse

        public int WarehouseID { get; set; }
        public Warehouse? Warehouse { get; set; }
    }
}
