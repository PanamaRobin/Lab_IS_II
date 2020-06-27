using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMICISite.Models
{
	public class SolicitudVM
	{
		public int IdSolicitud { set; get; }
		public string Descripcion { set; get; }
		public string Fecha { set; get; }
		public string CreadoPor { set; get; }
		public string Estado { set; get; }
	}
}