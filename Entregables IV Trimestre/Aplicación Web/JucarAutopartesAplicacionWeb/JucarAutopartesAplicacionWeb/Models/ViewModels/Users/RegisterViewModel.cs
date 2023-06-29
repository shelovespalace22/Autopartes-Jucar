using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace JucarAutopartesAplicacionWeb.Models.ViewModels.Users
{
	public class RegisterViewModel
	{
		//Propiedades User.cs

		[Required(ErrorMessage = "¡Ingrese el tipo de documento!")]
		[MaxLength(50)]
		[RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "¡El campo no permite números (9), símbolos (+) o cáracteres especiales (@)!")]
		[DisplayName("Tipo Documento")]
		public string? DocumentType { get; set; }

		[Required(ErrorMessage = "¡Ingrese el número de documento!")]
		[MaxLength(10)]
		[RegularExpression("^\\d{1,10}$", ErrorMessage = "¡El campo no permite números (9), símbolos (+) o cáracteres especiales (@)!")]
		[DisplayName("Documento")]
		public string? DocumentNumber { get; set; }

		[Required(ErrorMessage = "¡Ingrese el primer nombre!")]
		[MaxLength(50)]
		[RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "¡El campo no permite números (9), símbolos (+) o cáracteres especiales (@)!")]
		[DisplayName("Primer Nombre")]
		public string? FirstName { get; set; }

		[MaxLength(50)]
		[RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "¡El campo no permite números (9), símbolos (+) o cáracteres especiales (@)!")]
		[DisplayName("Segundo Nombre")]
		public string? SecondName { get; set; }

		[Required(ErrorMessage = "¡Ingrese el primer apellido!")]
		[MaxLength(50)]
		[RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "¡El campo no permite números (9), símbolos (+) o cáracteres especiales (@)!")]
		[DisplayName("Primer Apellido")]
		public string? FirstSurname { get; set; }

		[MaxLength(50)]
		[RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "¡El campo no permite números (9), símbolos (+) o cáracteres especiales (@)!")]
		[DisplayName("SegundoApellido")]
		public string? SecondSurname { get; set; }

		[Required(ErrorMessage = "¡Escoga una de las opciones!")]
		[MaxLength(10)]
		[RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "¡El campo no permite números (9), símbolos (+) o cáracteres especiales (@)!")]
		[DisplayName("Sexo")]
		public string? Sex { get; set; }

		[Required(ErrorMessage = "¡Seleccione su fecha de cumpleaños!")]
		[DisplayName("Fecha de Nacimiento")]
		public DateTime BirthDate { get; set; }

		[Required(ErrorMessage = "¡Ingrese el lugar de nacimiento!")]
		[MaxLength(100)]
		[RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "¡El campo no permite números (9), símbolos (+) o cáracteres especiales (@)!")]
		[DisplayName("Lugar de Nacimiento")]
		public string? BirthCity { get; set; }

		[Required(ErrorMessage = "¡Ingrese la ciudad de residencia!")]
		[MaxLength(100)]
		[RegularExpression("^[A-Za-zÁÉÍÓÚáéíóúÜüÑñ\\s]+$", ErrorMessage = "¡El campo no permite números (9), símbolos (+) o cáracteres especiales (@)!")]
		[DisplayName("Ciudad de Residencia")]
		public string? CityResidence { get; set; }

		//Propiedades de UserPhone.cs

		[Required(ErrorMessage = "¡Escoga una opción de tipo de teléfono!")]
		[DisplayName("Tipo Teléfono")]
		public string? PhoneType { get; set; }

		[Required(ErrorMessage = "¡Ingrese el número teléfonico!")]
		[DisplayName("Numero Teléfono")]
		public string? PhoneNumber { get; set; }

		[Required(ErrorMessage = "¡El correo es obligatorio!")]
		[EmailAddress(ErrorMessage = "¡Ingrese una dirección de correo válida!")]
		[DisplayName("Correo")]
		public string Email { get; set; }

		[Required(ErrorMessage = "¡La clave es obligatoria!")]
		[StringLength(50, ErrorMessage = "La longitud máxima de la {0} es de {2} caracteres", MinimumLength = 5)]
		[DataType(DataType.Password)]
		[DisplayName("Clave")]
		public string Password { get; set; }

		[Required(ErrorMessage = "¡La confirmación de la clave es obligatoria!")]
		[Compare("Password", ErrorMessage = "¡Las contraseñas no coinciden!")]
		[DataType(DataType.Password)]
		[DisplayName("Confirmar Clave")]
		public string ConfirmedPassword { get; set; }
	}
}
