﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wcfMinIndustria.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SMICIEntidad : DbContext
    {
        public SMICIEntidad()
            : base("name=SMICIEntidad")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Baches> Baches { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<InformeBache> InformeBache { get; set; }
        public virtual DbSet<ReporteDano> ReporteDano { get; set; }
    
        public virtual ObjectResult<LOGIN_Result> LOGIN(string eMAIL, string pASS)
        {
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var pASSParameter = pASS != null ?
                new ObjectParameter("PASS", pASS) :
                new ObjectParameter("PASS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LOGIN_Result>("LOGIN", eMAILParameter, pASSParameter);
        }
    
        public virtual int USP_REGISTRO_SOLICITUD_REPORTE_BACHE(string cALLE, string dISTRITO, string tAMANO, string pOSICION, ObjectParameter rESPUESTA, ObjectParameter dESCRIPCION, ObjectParameter iDNuevaSolicitud)
        {
            var cALLEParameter = cALLE != null ?
                new ObjectParameter("CALLE", cALLE) :
                new ObjectParameter("CALLE", typeof(string));
    
            var dISTRITOParameter = dISTRITO != null ?
                new ObjectParameter("DISTRITO", dISTRITO) :
                new ObjectParameter("DISTRITO", typeof(string));
    
            var tAMANOParameter = tAMANO != null ?
                new ObjectParameter("TAMANO", tAMANO) :
                new ObjectParameter("TAMANO", typeof(string));
    
            var pOSICIONParameter = pOSICION != null ?
                new ObjectParameter("POSICION", pOSICION) :
                new ObjectParameter("POSICION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_REGISTRO_SOLICITUD_REPORTE_BACHE", cALLEParameter, dISTRITOParameter, tAMANOParameter, pOSICIONParameter, rESPUESTA, dESCRIPCION, iDNuevaSolicitud);
        }
    
        public virtual int ELIMINAR_BACHES(Nullable<int> iDBACHE)
        {
            var iDBACHEParameter = iDBACHE.HasValue ?
                new ObjectParameter("IDBACHE", iDBACHE) :
                new ObjectParameter("IDBACHE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELIMINAR_BACHES", iDBACHEParameter);
        }
    
        public virtual ObjectResult<LISTADO_BACHES_Result> LISTADO_BACHES(string iDUSUARIO)
        {
            var iDUSUARIOParameter = iDUSUARIO != null ?
                new ObjectParameter("IDUSUARIO", iDUSUARIO) :
                new ObjectParameter("IDUSUARIO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LISTADO_BACHES_Result>("LISTADO_BACHES", iDUSUARIOParameter);
        }
    
        public virtual int USP_REGISTRO_INFORME(string ubicacion, Nullable<double> tamano, string brigada, string equipamiento, string horasDeReparacion, string estadoBache, string cantRelleno, Nullable<double> costoBache, Nullable<int> idBache, ObjectParameter rESPUESTA, ObjectParameter dESCRIPCION, ObjectParameter iDNuevaSolicitud)
        {
            var ubicacionParameter = ubicacion != null ?
                new ObjectParameter("Ubicacion", ubicacion) :
                new ObjectParameter("Ubicacion", typeof(string));
    
            var tamanoParameter = tamano.HasValue ?
                new ObjectParameter("Tamano", tamano) :
                new ObjectParameter("Tamano", typeof(double));
    
            var brigadaParameter = brigada != null ?
                new ObjectParameter("Brigada", brigada) :
                new ObjectParameter("Brigada", typeof(string));
    
            var equipamientoParameter = equipamiento != null ?
                new ObjectParameter("Equipamiento", equipamiento) :
                new ObjectParameter("Equipamiento", typeof(string));
    
            var horasDeReparacionParameter = horasDeReparacion != null ?
                new ObjectParameter("HorasDeReparacion", horasDeReparacion) :
                new ObjectParameter("HorasDeReparacion", typeof(string));
    
            var estadoBacheParameter = estadoBache != null ?
                new ObjectParameter("EstadoBache", estadoBache) :
                new ObjectParameter("EstadoBache", typeof(string));
    
            var cantRellenoParameter = cantRelleno != null ?
                new ObjectParameter("CantRelleno", cantRelleno) :
                new ObjectParameter("CantRelleno", typeof(string));
    
            var costoBacheParameter = costoBache.HasValue ?
                new ObjectParameter("CostoBache", costoBache) :
                new ObjectParameter("CostoBache", typeof(double));
    
            var idBacheParameter = idBache.HasValue ?
                new ObjectParameter("IdBache", idBache) :
                new ObjectParameter("IdBache", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_REGISTRO_INFORME", ubicacionParameter, tamanoParameter, brigadaParameter, equipamientoParameter, horasDeReparacionParameter, estadoBacheParameter, cantRellenoParameter, costoBacheParameter, idBacheParameter, rESPUESTA, dESCRIPCION, iDNuevaSolicitud);
        }
    
        public virtual int USP_REGISTRO_SOLICITUD_BACHE(string cALLE, string dISTRITO, string tAMANO, string pOSICION, ObjectParameter rESPUESTA, ObjectParameter dESCRIPCION, ObjectParameter iDNuevaSolicitud)
        {
            var cALLEParameter = cALLE != null ?
                new ObjectParameter("CALLE", cALLE) :
                new ObjectParameter("CALLE", typeof(string));
    
            var dISTRITOParameter = dISTRITO != null ?
                new ObjectParameter("DISTRITO", dISTRITO) :
                new ObjectParameter("DISTRITO", typeof(string));
    
            var tAMANOParameter = tAMANO != null ?
                new ObjectParameter("TAMANO", tAMANO) :
                new ObjectParameter("TAMANO", typeof(string));
    
            var pOSICIONParameter = pOSICION != null ?
                new ObjectParameter("POSICION", pOSICION) :
                new ObjectParameter("POSICION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_REGISTRO_SOLICITUD_BACHE", cALLEParameter, dISTRITOParameter, tAMANOParameter, pOSICIONParameter, rESPUESTA, dESCRIPCION, iDNuevaSolicitud);
        }
    
        public virtual int USP_REGISTRO_DANO_DEL_AUTO(string tipoDano, Nullable<double> costoReparacion, Nullable<int> idBache, ObjectParameter rESPUESTA, ObjectParameter dESCRIPCION, ObjectParameter iDNuevaSolicitud)
        {
            var tipoDanoParameter = tipoDano != null ?
                new ObjectParameter("TipoDano", tipoDano) :
                new ObjectParameter("TipoDano", typeof(string));
    
            var costoReparacionParameter = costoReparacion.HasValue ?
                new ObjectParameter("CostoReparacion", costoReparacion) :
                new ObjectParameter("CostoReparacion", typeof(double));
    
            var idBacheParameter = idBache.HasValue ?
                new ObjectParameter("IdBache", idBache) :
                new ObjectParameter("IdBache", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_REGISTRO_DANO_DEL_AUTO", tipoDanoParameter, costoReparacionParameter, idBacheParameter, rESPUESTA, dESCRIPCION, iDNuevaSolicitud);
        }
    }
}
