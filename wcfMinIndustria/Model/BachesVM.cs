using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfMinIndustria.Model
{
    public class BachesVM
    {
        public int IdBache { set; get; }
        public string Calle { set; get; }
        public string Distrito { set; get; }
        public string Tamano { set; get; }
        public string Posicion { set; get; }
        public string Usuario { set; get; }
        public string Prioridad { set; get; }
        public string Fcreacion { set; get; }
    }
}