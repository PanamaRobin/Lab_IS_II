﻿using System;
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
        //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* LISTADOS -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //LISTADO DE BACHES CIUDADANO
        public List<BachesVM> Listado()
        {
            List<BachesVM> objLista = new List<BachesVM>();
            try
            {
                var objBaches = db.Baches;

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
                        Fcreacion = reg.Fcreacion.ToString("yyyy-MM-dd"),
                        Estado = reg.Estado
                    });   
                }
            }
            catch (Exception ex)
            {
                
            }
            return objLista;
        }

        //LISTADO DE DAÑOS AL AUTO
        public List<DanoVM> ListadoDano()
        {
            List<DanoVM> objLista = new List<DanoVM>();
            try
            {
                var objBaches = db.ReporteDano;

                foreach (var reg in objBaches)
                {
                    objLista.Add(new DanoVM()
                    {
                        IdReporte = reg.IdReporte,
                        TipoDano = reg.TipoDano,
                        CostoReparacion = reg.CostoReparacion,
                        IdUsuario = reg.IdUsuario,
                        IdBache = reg.IdBache,
                        Fcreacion = reg.Fecha.ToString("yyyy-MM-dd"),
                        Estado = reg.Estado
                    });
                }
            }
            catch (Exception ex)
            {

            }
            return objLista;
        }

        //LISTADO DE INFORME DE REPORTE
        public List<InformeVM> ListadoInforme()
        {
            List<InformeVM> objLista = new List<InformeVM>();
            try
            {
                var objBaches = db.InformeBache;

                foreach (var reg in objBaches)
                {
                    objLista.Add(new InformeVM()
                    {
                        IdInformeBache = reg.IdInformeBache,
                        Ubicacion = reg.Ubicacion,
                        Tamano = reg.Tamano,
                        Brigada = reg.Brigada,
                        Equipamiento = reg.Equipamiento,
                        HorasDeReparacion = reg.HorasDeReparacion,
                        EstadoBache = reg.EstadoBache,
                        CantRelleno = reg.CantRelleno,
                        CostoBache = reg.CostoBache,
                        IdBache = reg.IdBache,
                    });
                }
            }
            catch (Exception ex)
            {

            }
            return objLista;
        }
        //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* REGISTROS -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

        //REGISTRAR REPORTE DE BACHE
        public Respuesta RegistroReporteBache(BachesVM objRegistroBaches)
        {
            Respuesta objResp = new Respuesta();

            System.Data.Entity.Core.Objects.ObjectParameter Resp = new System.Data.Entity.Core.Objects.ObjectParameter("RESPUESTA", 0);
            System.Data.Entity.Core.Objects.ObjectParameter DescError = new System.Data.Entity.Core.Objects.ObjectParameter("DESCRIPCION", "");
            System.Data.Entity.Core.Objects.ObjectParameter IdNuevaSolicitud = new System.Data.Entity.Core.Objects.ObjectParameter("IDNuevaSolicitud", 0);

            try
            {
                db.USP_REGISTRO_SOLICITUD_BACHE(objRegistroBaches.Calle, objRegistroBaches.Distrito, objRegistroBaches.Tamano,
                                                        objRegistroBaches.Posicion, Resp, DescError, IdNuevaSolicitud);

                objResp.IdRespuesta = (int)Resp.Value;
                objResp.Mensaje = DescError.Value.ToString();

                if (objResp.IdRespuesta == 0) //Sin Error
                {
                    objRegistroBaches.IdBache = Convert.ToInt16(IdNuevaSolicitud.Value);

                    objResp.IdSolicitud = Convert.ToInt16(objRegistroBaches.IdBache);

                }
            }
            catch (Exception ex)
            {
                objResp.IdRespuesta = 1;

            }
            return objResp;
        }

        //REGISTRAR REPORTE DE DAÑOS
        public Respuesta RegistroReporteDano(DanoVM objRegistroDano)
        {
            Respuesta objResp = new Respuesta();

            System.Data.Entity.Core.Objects.ObjectParameter Resp = new System.Data.Entity.Core.Objects.ObjectParameter("RESPUESTA", 0);
            System.Data.Entity.Core.Objects.ObjectParameter DescError = new System.Data.Entity.Core.Objects.ObjectParameter("DESCRIPCION", "");
            System.Data.Entity.Core.Objects.ObjectParameter IdNuevaSolicitud = new System.Data.Entity.Core.Objects.ObjectParameter("IDNuevaSolicitud", 0);

            try
            {
                db.USP_REGISTRO_DANO_DEL_AUTO(objRegistroDano.TipoDano, objRegistroDano.CostoReparacion,
                                                        objRegistroDano.IdBache, Resp, DescError, IdNuevaSolicitud);

                objResp.IdRespuesta = (int)Resp.Value;
                objResp.Mensaje = DescError.Value.ToString();

                if (objResp.IdRespuesta == 0) //Sin Error
                {
                    objRegistroDano.IdReporte = Convert.ToInt16(IdNuevaSolicitud.Value);

                    objResp.IdSolicitud = Convert.ToInt16(objRegistroDano.IdReporte);
                }
            }
            catch (Exception ex)
            {
                objResp.IdRespuesta = 1;

            }
            return objResp;
        }
        //REGISTRAR INFORME DE REPORTE DE BACHES
        public Respuesta RegistroInforme(InformeVM objRegistroInforme)
        {
            Respuesta objResp = new Respuesta();

            System.Data.Entity.Core.Objects.ObjectParameter Resp = new System.Data.Entity.Core.Objects.ObjectParameter("RESPUESTA", 0);
            System.Data.Entity.Core.Objects.ObjectParameter DescError = new System.Data.Entity.Core.Objects.ObjectParameter("DESCRIPCION", "");
            System.Data.Entity.Core.Objects.ObjectParameter IdNuevaSolicitud = new System.Data.Entity.Core.Objects.ObjectParameter("IDNuevaSolicitud", 0);

            try
            {
                db.USP_REGISTRO_INFORME(objRegistroInforme.Ubicacion, objRegistroInforme.Tamano, objRegistroInforme.Brigada, objRegistroInforme.Equipamiento,
                    objRegistroInforme.HorasDeReparacion, objRegistroInforme.EstadoBache, objRegistroInforme.CantRelleno, objRegistroInforme.CostoBache,
                    objRegistroInforme.IdBache, Resp, DescError, IdNuevaSolicitud);

                objResp.IdRespuesta = (int)Resp.Value;
                objResp.Mensaje = DescError.Value.ToString();

                if (objResp.IdRespuesta == 0) //Sin Error
                {
                    objRegistroInforme.IdInformeBache = Convert.ToInt16(IdNuevaSolicitud.Value);

                    objResp.IdSolicitud = Convert.ToInt16(objRegistroInforme.IdInformeBache);

                }
            }
            catch (Exception ex)
            {
                objResp.IdRespuesta = 1;

            }
            return objResp;
        }

    }
}