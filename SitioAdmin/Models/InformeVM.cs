using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SitioAdmin.Models
{
	public class InformeVM
	{
        public int IdInformeBache { set; get; }
        [Display(Name = "Ubicación")]
        public string Ubicacion { set; get; }
        [Display(Name = "Tamaño")]
        [Range(1, 10, ErrorMessage = "Solo valores del 1 al 10")]
        public double Tamano { set; get; }
        public string Brigada { set; get; }
        public string Equipamiento { set; get; }
        [Display(Name = "Horas de reparación")]
        public string HorasDeReparacion { set; get; }
        [Display(Name = "Estado del bache")]
        public string EstadoBache { set; get; }
        [Display(Name = "Cantidad de relleno utilizada")]
        public string CantRelleno { set; get; }
        [Display(Name = "Costo de la reparación del Bache")]
        public double CostoBache { set; get; }
        [Display(Name = "No. de Bache")]
        public int IdBache { set; get; }

    }
}