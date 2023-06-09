﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace JucarAutopartesAplicacionWeb.Models.Providers
{
    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProviderID { get; set; }

        [Required(ErrorMessage = "¡Ingrese un correo electrónico!")]
        [EmailAddress(ErrorMessage = "¡Ingrese una cuenta de correo electrónico válida!")]
        [DisplayName("Correo Electrónicos")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "¡Ingrese el tipo de producto!")]
        [MaxLength(50)]
        [RegularExpression("^[A-Za-z\\s]+$")]
        [DisplayName("Tipo de Producto")]
        public string? ProductType { get; set; }

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

        public Provider()
        {
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos 

        //ProviderAddress

        public ICollection<ProviderAddress> ProviderAddresses { get; set; }

        //ProviderPhone

        public ICollection<ProviderPhone> ProviderPhones { get; set; }

    }
}
