using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfMinIndustria.Model
{
    public class UsuariosVM
    {
        public int IdUsuario { set; get; }
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
        public string Correo { set; get; }
        public string Contrasena { set; get; }
    }
}