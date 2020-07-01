using SitioAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioAdmin.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult IndexFuncionario()
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
                    Fcreacion = fila.Fcreacion,
                    Estado = fila.Estado
                });
            }
            return View(objLista);
        }

        //MOSTRAR INFORME DE REPORTE
        public ActionResult InformeDeReporte()
        {
            List<InformeVM> objLista = new List<InformeVM>();

            wcfServicio.IwcfExtServiceClient objServicio = new wcfServicio.IwcfExtServiceClient();

            var objResp = objServicio.ListadoInforme();

            foreach (var fila in objResp)
            {
                objLista.Add(new InformeVM()
                {
                    IdInformeBache = fila.IdInformeBache,
                    Ubicacion = fila.Ubicacion,
                    Tamano = fila.Tamano,
                    Brigada = fila.Brigada,
                    Equipamiento = fila.Equipamiento,
                    HorasDeReparacion = fila.HorasDeReparacion,
                    EstadoBache = fila.EstadoBache,
                    CantRelleno = fila.CantRelleno,
                    CostoBache = fila.CostoBache,
                    IdBache = fila.IdBache,
                });
            }
            return View(objLista);
        }
        //VISTA QUE MUESTRA LOS REPORTES DE DANO
        public ActionResult IndexDano()
        {
            List<DanoVM> objLista = new List<DanoVM>();

            wcfServicio.IwcfExtServiceClient objServicio = new wcfServicio.IwcfExtServiceClient();

            var objResp = objServicio.ListadoDano();

            foreach (var fila in objResp)
            {
                objLista.Add(new DanoVM()
                {
                    IdReporte = fila.IdReporte,
                    TipoDano = fila.TipoDano,
                    CostoReparacion = fila.CostoReparacion,
                    IdUsuario = fila.IdUsuario,
                    IdBache = fila.IdBache,
                    Fcreacion = fila.Fcreacion,
                    Estado = fila.Estado
                });
            }
            return View(objLista);
        }

        // VISTA CREAR INFORME 
        public ActionResult CreateInformeBache()
        {
            return View();
        }
        //CREACION DE INFROME DE REPORTE
        [HttpPost]
        public ActionResult CrearInforme(InformeVM ObjInforme)
        {
            string strTitulo = "⚠ Se ha producido un error ⚠";
            bool boolexitoso = false;
            string strMensaje = "El correo esta ya siendo utilizado...";
            int IdSolicitud = 0;
            if (ModelState.IsValid)
            {
                wcfServicio.IwcfExtServiceClient objServicio = new wcfServicio.IwcfExtServiceClient();
                wcfServicio.InformeVM objReg = new wcfServicio.InformeVM();
                try
                {
                    objReg.Ubicacion = ObjInforme.Ubicacion;
                    objReg.Tamano = ObjInforme.Tamano;
                    objReg.Brigada = ObjInforme.Brigada;
                    objReg.Equipamiento = ObjInforme.Equipamiento;
                    objReg.HorasDeReparacion = ObjInforme.HorasDeReparacion;
                    objReg.EstadoBache = ObjInforme.EstadoBache;
                    objReg.CantRelleno = ObjInforme.CantRelleno;
                    objReg.CostoBache = ObjInforme.CostoBache;
                    objReg.IdBache = ObjInforme.IdBache;

                    var objResp = objServicio.RegistroInforme(objReg);

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