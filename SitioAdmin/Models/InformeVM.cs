using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitioAdmin.Models
{
	public class InformeVM
	{
		public int IdInformeBache { set; get; }
		public string Ubicacion { set; get; }
		public double Tamano { set; get; }
		public string Brigada { set; get; }
		public string Equipamiento { set; get; }
		public string HorasDeReparacion { set; get; }
		public string EstadoBache { set; get; }
		public string CantRelleno { set; get; }
		public double CostoBache { set; get; }
		public int IdBache { set; get; }

	}
}