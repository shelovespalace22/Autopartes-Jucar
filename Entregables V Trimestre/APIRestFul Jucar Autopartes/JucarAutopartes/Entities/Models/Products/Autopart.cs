using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Sales;

namespace Entities.Models.Products
{
    public class Autopart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AutopartID { get; set; }

        [Required(ErrorMessage = "¡Ingrese el nombre de la autoparte!")]
        [MaxLength(50, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[\\w\\s'\"/.\\u00E1-\\u00FA]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        [MaxLength(200, ErrorMessage = "Ha superado el límite de caracteres permitido")]
        [RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "El formato del campo {0} no es válido. Asegúrate de seguir el patrón requerido.")]
        [DisplayName("Descripción")]
        public string? Description { get; set; }

        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Inventario")]
        public int Inventory { get; set; }

        [Required(ErrorMessage = "Ingrese el precio de la autoparte.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "El formato del campo {0} no es válido. Solo se permiten números (0-9).")]
        [DisplayName("Precio")]
        public decimal Value { get; set; }

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

        public Autopart()
        {
            Description = "No tiene descripción.";
            Inventory = 0;
            State = true;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        public void setModificationDate()
        {
            ModificationDate = DateTime.Now;
        }

        //Relaciones con otros modelos

        //Subcategory
        public Guid SubcategoryId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una Subcategoría")]
        [DisplayName("Subcategoría")]
        public Subcategory? Subcategory { get; set; }

        //Loss

        public ICollection<Loss>? Losses { get; set; }


        //OrderDetail

        public ICollection<OrderDetail>? OrderDetails { get; set; }

        //RawMaterial

        public Guid RawMaterialId { get; set; }

        [Required(ErrorMessage = "Escoga un material para la autoparte")]
        [DisplayName("Material")]
        public RawMaterial? Material { get; set; }
    }
}
