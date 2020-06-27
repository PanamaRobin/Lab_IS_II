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
    
        public virtual DbSet<UsuariosExt> UsuariosExt { get; set; }
        public virtual DbSet<UsuariosMICI> UsuariosMICI { get; set; }
    
        public virtual int USP_SMICI_LOGIN(string eMAIL, string pASS, ObjectParameter idUsuario)
        {
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var pASSParameter = pASS != null ?
                new ObjectParameter("PASS", pASS) :
                new ObjectParameter("PASS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_SMICI_LOGIN", eMAILParameter, pASSParameter, idUsuario);
        }
    
        public virtual int USP_SMICI_REGISTRO(string eMAIL, string pASS, ObjectParameter idUsuario)
        {
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var pASSParameter = pASS != null ?
                new ObjectParameter("PASS", pASS) :
                new ObjectParameter("PASS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_SMICI_REGISTRO", eMAILParameter, pASSParameter, idUsuario);
        }
    }
}
