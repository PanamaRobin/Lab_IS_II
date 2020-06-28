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
        // GET: Ciudadano
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
                });
            }
            return View(objLista);
        }
    }
}