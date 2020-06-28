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
    }
}