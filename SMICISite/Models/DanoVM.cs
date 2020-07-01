using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SMICISite.Models
{
    public class DanoVM
    {
        public int IdReporte { set; get; }
        [Display(Name = "Tipo de daño")]
        public string TipoDano { set; get; }
        [Display(Name = "Costo de la reparación")]
        public double CostoReparacion { set; get; }
        public string IdUsuario { set; get; }
        [Display(Name = "No. de Bache")]
        public int IdBache { set; get; }
        public string Fcreacion { set; get; }
    }
}