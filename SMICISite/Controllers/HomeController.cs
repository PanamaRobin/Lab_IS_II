using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMICISite.Models;

namespace SMICISite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() 
        {
            return View();
        }

        // LOGIN
        public ActionResult Login(UsuariosVM objUsuariosVM)
        {
            string strTitulo = "titulo Error ";
            bool boolExitoso = false;
            string strMensaje = "Error descripcion";

            //int Resp = 0;

            if (ModelState.IsValid)
            {
                wcfServicio.IwcfExtServiceClient objServicio = new wcfServicio.IwcfExtServiceClient();

                try
                {
                    var Resp = objServicio.Login(objUsuariosVM.Correo, objUsuariosVM.Contrasena);

                    if (Resp.IdUsuario == 0)
                    {
                        strTitulo = "Credenciales Incorrectas";
                        boolExitoso = false;
                        strMensaje = "Usuario o Contraseña Incorrecta...";
                    }
                    else
                    {
                        UsuariosVM objUsuario = new UsuariosVM();
                        objUsuario.IdUsuario = Resp.IdUsuario;
                        objUsuario.Nombre = Resp.Nombre;
                        objUsuario.Correo = Resp.Correo;

                        strTitulo = "Usuario Encontrado";
                        boolExitoso = true;
                        strMensaje = "El Id del Usuario Encontrado es = " + Resp;

                    }

                }
                catch (Exception ex)
                {
                    strTitulo = "Exepción Encontrada";
                    boolExitoso = false;
                    strMensaje = "Ocurrió una excepción no esperada... Detalles =" + ex.Message;
                }

            }

            var objRes = new { success = boolExitoso, titulo = strTitulo, mensaje = strMensaje };

            return Json(objRes, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Registro()
        {
            return View();
        }
    }
    
}
