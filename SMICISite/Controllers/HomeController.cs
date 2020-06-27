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
        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Login2(LoginVM objLogin)
        {
            string titulo = "Titulo Error";
            bool exitoso = false;
            string mensaje = "Error Descripcion";
            int Resp = 0;
            if (ModelState.IsValid)
            {
                wcfServicio.IwcfExtServiceClient objServicio = new wcfServicio.IwcfExtServiceClient();

                try
                {
                    Resp = objServicio.Login(objLogin.Email, objLogin.Pass);
                    if (Resp == 0)
                    {
                        titulo = "Credenciales Incorrectas";
                        exitoso = false;
                        mensaje = "Usuario o Contraseña Incorrecta";
                    }
                    else
                    {
                        titulo = "Usuario Encontrado";
                        exitoso = true;
                        mensaje = "El ID del Usuario Encontrado es = " + Resp;
                    }
                }
                catch (Exception ex)
                {
                    titulo = "Excepción Encontrada";
                    exitoso = false;
                    mensaje = "Ocurrió una excepción no esperada... Detalles = " + ex.Message;
                }
            }

            var objRes = new { success = exitoso, titulo = titulo, mensaje = mensaje };

            return Json(objRes, JsonRequestBehavior.AllowGet);
        }
    }
}
