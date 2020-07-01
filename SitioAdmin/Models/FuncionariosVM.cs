using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SitioAdmin.Models
{
	public class FuncionariosVM
	{
		public int IdUsuario { set; get; }
		public string Nombre { set; get; }
		public string Direccion { set; get; }
		public string Telefono { set; get; }

		[Required(ErrorMessage = "El correo es obligatorio...")]
		[Display(Name = "Correo")]
		public string Correo { set; get; }

		[Display(Name = "Contraseña")]
		[Required(ErrorMessage = "Favor ingrese una contraseña...")]
		//[RegularExpression(@"^.*(?=.*[!@#$%^&*\(\)_\-+=]).*$", ErrorMessage = "El password debe ser ....")]
		public string Contrasena { set; get; }
	}
}