using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wcfMinIndustria.Model;

namespace wcfMinIndustria.Model
{
    public class DataManager
    {
        private SMICIEntidad db = new SMICIEntidad();

        public int Login (string Email, string pass)
        {
            int Res = 0;

            System.Data.Entity.Core.Objects.ObjectParameter Resultado = new
            System.Data.Entity.Core.Objects.ObjectParameter("IdUsuario", 0);

            db.USP_SMICI_LOGIN(Email, pass, Resultado);

            Res = Convert.ToInt32( Resultado.Value);

            return Res;
        }

        public int Registro(string Email, string pass)
        {
            int Res = 0;

            System.Data.Entity.Core.Objects.ObjectParameter Resultado = new
                 System.Data.Entity.Core.Objects.ObjectParameter("IdUsuario", 0);

            db.USP_SMICI_REGISTRO(Email, pass, Resultado);

            Res = Convert.ToInt32(Resultado.Value);

            return Res;
        }
    }
}