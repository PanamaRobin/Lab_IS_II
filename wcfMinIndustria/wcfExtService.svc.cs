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

        //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LISTADOS -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //LISTADO DE BACHES CIUDADANO
        public List<BachesVM> Listado()
        {
            List<BachesVM> Res = new List<BachesVM>();

            Res = objDataManager.Listado();

            return Res;
        }

        //LISTADO DE DAÑOS CIUDADANO
        public List<DanoVM> ListadoDano()
        {
            List<DanoVM> Res = new List<DanoVM>();

            Res = objDataManager.ListadoDano();

            return Res;
        }

        //LISTADO DE INFORME DE REPORTE
        public List<InformeVM> ListadoInforme()
        {
            List<InformeVM> Res = new List<InformeVM>();

            Res = objDataManager.ListadoInforme();

            return Res;
        }

        //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* REGISTROS -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //REGISTRO DE BACHES CIUDADANO
        public Respuesta RegistroReporteBache(BachesVM objRegistroBaches)
        {
            Respuesta objResp = new Respuesta();

            objResp = objDataManager.RegistroReporteBache(objRegistroBaches);

            return objResp;
        }

        //REGISTRO DE DAÑOS CIUDADANO
        public Respuesta RegistroReporteDano(DanoVM objRegistroDano)
        {
            Respuesta objResp = new Respuesta();

            objResp = objDataManager.RegistroReporteDano(objRegistroDano);

            return objResp;
        }

        //REGISTRO DE INFORME DE REPORTE
        public Respuesta RegistroInforme(InformeVM objRegistroInforme)
        {
            Respuesta objResp = new Respuesta();

            objResp = objDataManager.RegistroInforme(objRegistroInforme);

            return objResp;
        }

    }
}