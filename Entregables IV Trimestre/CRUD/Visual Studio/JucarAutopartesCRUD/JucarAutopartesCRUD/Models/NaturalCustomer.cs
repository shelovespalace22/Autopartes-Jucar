using System.ComponentModel.DataAnnotations;
using JucarAutopartesCRUD.Models.Enums;

namespace JucarAutopartesCRUD.Models
{
    public class NaturalCustomer : Customer
    {
        [Required(ErrorMessage = "¡Escoga una de las opciones!"), ]
        public DocumentType DocumentType { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(10), RegularExpression("^[0-9]+$")]
        public string? DocumentNumber { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50), RegularExpression("^[a-zA-Z]+$")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50), RegularExpression("^[a-zA-Z]+$")]
        public string? SecondName { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50), RegularExpression("^[a-zA-Z]+$")]
        public string? FirstLastName { get; set; }

        [Required(ErrorMessage = "¡Ingrese un valor!"), StringLength(50), RegularExpression("^[a-zA-Z]+$")]
        public string? SecondLastName { get; set; }

    }
}
