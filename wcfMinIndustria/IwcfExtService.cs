using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfMinIndustria
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IwcfExtService" in both code and config file together.
    [ServiceContract]
    public interface IwcfExtService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int Login(string strUsuario, string strPass);

        [OperationContract]
        int Registro(string strUsuario, string strPass);

        [OperationContract]
        int NuevaSolicitud();


        [OperationContract]
        int DetalleSolicitud();

        [OperationContract]
        int Solicitudes();

    }
}
