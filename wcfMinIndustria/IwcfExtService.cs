using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wcfMinIndustria.Model;

namespace wcfMinIndustria
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IwcfExtService" in both code and config file together.
    [ServiceContract]
    public interface IwcfExtService
    {
        //LOGIN
        [OperationContract]
        UsuariosVM Login(string strUsuario, string strPass);

        //LISTADO DE BACHES CIUDADANO
        [OperationContract]
        List<BachesVM> Listado();

        //LISTADO DE DAÑOS CIUDADANO
        [OperationContract]
        List<DanoVM> ListadoDano();

        //LISTADO DE INFORME DE REPORTE
        [OperationContract]
        List<InformeVM> ListadoInforme();

        //REGISTRO DE BACHES CIUDADANO
        [OperationContract]
        Respuesta RegistroReporteBache(BachesVM objRegistroBaches);

        //REGISTRO DE DAÑOS CIUDADANO
        [OperationContract]
        Respuesta RegistroReporteDano(DanoVM objRegistroDano);

        //REGISTRO DE INFORME DE REPORTE
        [OperationContract]
        Respuesta RegistroInforme(InformeVM objRegistroInforme);
    }
}