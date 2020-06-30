using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfMinIndustria
{
    public class Respuesta
    {
        public int IdRespuesta { set; get; }
        public int IdSolicitud { set; get; }
        public string Mensaje { set; get; }
        public bool RespuestaOk { set; get; }
    }
}