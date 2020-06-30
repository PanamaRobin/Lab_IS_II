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
        DataManager objDataManager = new DataManager();

        //LOGIN
        public UsuariosVM Login(string strUsuario, string strPass)
        {
            return objDataManager.Login(strUsuario, strPass);
        }

        //LISTADO DE BACHES CIUDADANO
        public List<BachesVM> Listado()
        {
            List<BachesVM> Res = new List<BachesVM>();

            Res = objDataManager.Listado();

            return Res;
        }

        //REPORTE DE BACHES CIUDADANO
        public Respuesta RegistroReporteBache(BachesVM objRegistroBaches)
        {
            Respuesta objResp = new Respuesta();

            objResp = objDataManager.RegistroReporteBache(objRegistroBaches);

            return objResp;
        }

        //REPORTE DE DAÑOS CIUDADANO
        public Respuesta RegistroReporteDano(DanoVM objRegistroDano)
        {
            Respuesta objResp = new Respuesta();

            objResp = objDataManager.RegistroReporteDano(objRegistroDano);

            return objResp;
        }

        //LISTADO DE DAÑOS CIUDADANO
        public List<DanoVM> ListadoDano()
        {
            List<DanoVM> Res = new List<DanoVM>();

            Res = objDataManager.ListadoDano();

            return Res;
        }
    }
}