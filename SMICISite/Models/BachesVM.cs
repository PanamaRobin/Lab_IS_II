using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SMICISite.Models
{
    public class BachesVM
    {
        public int IdBache { set; get; }
        public string Calle { set; get; }
        public string Distrito { set; get; }
        [Display(Name = "Tamaño")]
        public string Tamano { set; get; }
        [Display(Name = "Posición")]
        public string Posicion { set; get; }
        public string Usuario { set; get; }
        public string Prioridad { set; get; }
        public string Fcreacion { set; get; }
    }
}