using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wcfMinIndustria.Model;

namespace wcfMinIndustria
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "wcfExtService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select wcfExtService.svc or wcfExtService.svc.cs at the Solution Explorer and start debugging.
    public class wcfExtService : IwcfExtService
    {
        public void DoWork()
        {
        }

        public int Login(string strUsuario, string strPass)
        {
            int IdUsuario = 0;
            //llamar a la clase de Bds y obtener el resultado del login
            DataManager dm = new DataManager();
            IdUsuario = dm.Login(strUsuario, strPass);

            return IdUsuario;
        }

        public int Registro(string strUsuario, string strPass)
        {
            int Resultado = 0;
            //llamar a la clase de Bds y obtener el resultado
            DataManager dm = new DataManager();
            Resultado = dm.Registro(strUsuario, strPass);

            return Resultado;
        }

        public int NuevaSolicitud()
        {
            int Resultado = 0;
            // 
            //llamar a la clase de Bds y obtener el resultado

            return Resultado;
        }

        public int DetalleSolicitud()
        {
            int Resultado = 0;
            // 
            //llamar a la clase de Bds y obtener el resultado

            return Resultado;
        }

        public int Solicitudes()
        {
            int Resultado = 0;
            // 
            //llamar a la clase de Bds y obtener el resultado

            return Resultado;
        }


    }
}
