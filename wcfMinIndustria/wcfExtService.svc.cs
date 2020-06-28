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

        public UsuariosVM Login(string strUsuario, string strPass)
        {
            return objDataManager.Login(strUsuario, strPass);
        }
    }
}