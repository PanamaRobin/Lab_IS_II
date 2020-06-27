using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SMICISite.Models
{
	public class LoginVM
	{
		[Required(ErrorMessage = "El correo es obligatorio...")]
		[Display(Name = "Correo")]
		public string Email { set; get; }

		[Display(Name = "Contraseña")]
		[Required(ErrorMessage = "Favor ingrese una contraseña...")]
		//[RegularExpression(@"^.*(?=.*[!@#$%^&*\(\)_\-+=]).*$", ErrorMessage = "El password debe ser ....")]
		public string Pass { set; get; }
	}
}