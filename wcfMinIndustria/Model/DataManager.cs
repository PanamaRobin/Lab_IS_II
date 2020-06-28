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

        //LOGIN
        public UsuariosVM Login(string Email, string pass)
        {
            UsuariosVM objPerfilVM = new UsuariosVM();
            try
            {
                objPerfilVM.IdUsuario = 0;
                objPerfilVM.Nombre = "";
                objPerfilVM.Correo = "";

                var objPerfilSP = db.LOGIN(Email, pass);

                foreach (var reg in objPerfilSP)
                {
                    objPerfilVM.IdUsuario = reg.IdUsuario;
                    objPerfilVM.Nombre = reg.NombreUsuario;
                    objPerfilVM.Correo = reg.Correo;
                }
            }
            catch (Exception ex)
            {

            }
            return objPerfilVM;
        }

        //LISTADO DE BACHES CIUDADANO
        public List<BachesVM> Listado()
        {
            List<BachesVM> objLista = new List<BachesVM>();
            try
            {
                var objBaches = db.LISTADO_BACHES("Jorge");

                foreach (var reg in objBaches)
                {
                    objLista.Add(new BachesVM()
                    {
                        IdBache = reg.IdBache,
                        Calle = reg.Calle,
                        Distrito = reg.Distrito,
                        Tamano = reg.Tamano,
                        Posicion = reg.Posicion,
                        Usuario = reg.Usuario,
                        Prioridad = reg.Prioridad,
                    });   
                }
            }
            catch (Exception ex)
            {
                
            }
            return objLista;
        }
    }
}