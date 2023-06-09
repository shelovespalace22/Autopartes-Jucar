﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesAplicacionWeb.Models.Ubications
{
    public class Addressee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddresseeID { get; set; }

        [Required(ErrorMessage = "¡Ingresa el primer nombre!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Primer Nombre")]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Segundo Nombre")]
        public string? SecondName { get; set; }

        [Required(ErrorMessage = "¡Ingresa el primer apellido!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Primer Apellido")]
        public string? FirstSurname { get; set; }

        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Segundo Apellido")]
        public string? SecondSurname { get; set; }

        [Required]
        [DisplayName("Tipo de Documento")]
        public string? DocumntType { get; set; }

        [Required(ErrorMessage = "¡Ingresa el número de documento!")]
        [MaxLength(10)]
        [RegularExpression("^[0-9]+$")]
        [DisplayName("Número de Documento")]
        public string? DocumentNumber { get; set; }

        [Required]
        [DisplayName("Creación del Regístro")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modificación del Regístro")]
        public DateTime ModificationDate { get; set; }

        //Constructor

        public Addressee()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        public ICollection<Address> Addresses { get; set; }

    }
}
