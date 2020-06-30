using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMICISite.Models;

namespace SMICISite.Controllers
{
    public class CiudadanoController : Controller
    {
        //LISTADO DE REPORTES
        public ActionResult IndexCiudadano()
        {
            List<BachesVM> objLista = new List<BachesVM>();

            wcfServicio.IwcfExtServiceClient objServicio = new wcfServicio.IwcfExtServiceClient();

            var objResp = objServicio.Listado();

            foreach (var fila in objResp)
            {
                objLista.Add(new BachesVM()
                {
                    IdBache = fila.IdBache,
                    Calle = fila.Calle,
                    Distrito = fila.Distrito,
                    Tamano = fila.Tamano,
                    Posicion = fila.Posicion,
                    Usuario = fila.Usuario,
                    Prioridad = fila.Prioridad,
                    Fcreacion = fila.Fcreacion
                });
            }
            return View(objLista);
        }

        //VISTA CREAR REPORTE
        public ActionResult CreateReporte()
        {
            return View();
        }

        //CREACION DE REPORTE
        [HttpPost]
        public ActionResult CrearReporteBache(BachesVM ObjBaches)
        {
            string strTitulo = "⚠ Se ha producido un error ⚠";
            bool boolexitoso = false;
            string strMensaje = "El correo esta ya siendo utilizado...";
            int IdSolicitud = 0;
            if (ModelState.IsValid)
            {
                wcfServicio.IwcfExtServiceClient objServicio = new wcfServicio.IwcfExtServiceClient();
                wcfServicio.BachesVM objReg = new wcfServicio.BachesVM();
                try
                {
                    objReg.Calle = ObjBaches.Calle;
                    objReg.Distrito = ObjBaches.Distrito;
                    objReg.Tamano = ObjBaches.Tamano;
                    objReg.Posicion = ObjBaches.Posicion;

                    var objResp = objServicio.RegistroReporteBache(objReg);

                    if (objResp.IdRespuesta == 0)
                    {
                        strTitulo = "Solicitud Creada";
                        boolexitoso = true;
                        strMensaje = "La solicitud fue creada satisfactoriamente...";
                        IdSolicitud = objResp.IdSolicitud;

                    }
                    else
                    {
                        strTitulo = "Error al crear la solicitud";
                        boolexitoso = false;
                        strMensaje = objResp.Mensaje;
                        IdSolicitud = 0;
                    }

                }
                catch (Exception ex)
                {
                    strTitulo = "Exepcion Encontrada";
                    boolexitoso = false;
                    strMensaje = "Ocurrio una excepción no esperada... Detalles = " + ex.Message;
                    IdSolicitud = 0;
                }
            }
            var objRes = new { success = boolexitoso, titulo = strTitulo, mensaje = strMensaje, IdSolicitud = IdSolicitud };
            return Json(objRes, JsonRequestBehavior.AllowGet);
        }
    }
}