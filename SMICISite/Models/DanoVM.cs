using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMICISite.Models
{
    public class DanoVM
    {
        public int IdReporte { set; get; }
        public string TipoDano { set; get; }
        public double CostoReparacion { set; get; }
        public string IdUsuario { set; get; }
        public int IdBache { set; get; }
        public string Fcreacion { set; get; }
    }
}