﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class pruebaEntities1 : DbContext
    {
        public pruebaEntities1()
            : base("name=pruebaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cargos> cargos { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    
        public virtual ObjectResult<prclistaareas_Result> prclistaareas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prclistaareas_Result>("prclistaareas");
        }
    
        public virtual ObjectResult<prclistausuario_Result> prclistausuario(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prclistausuario_Result>("prclistausuario", idParameter);
        }
    
        public virtual int prcopeusu(string usu, string nom, string area, string tipo)
        {
            var usuParameter = usu != null ?
                new ObjectParameter("usu", usu) :
                new ObjectParameter("usu", typeof(string));
    
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var areaParameter = area != null ?
                new ObjectParameter("area", area) :
                new ObjectParameter("area", typeof(string));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prcopeusu", usuParameter, nomParameter, areaParameter, tipoParameter);
        }
    }
}
