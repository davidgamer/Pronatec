﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysPronatec.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SysPronatecEntities : DbContext
    {
        public SysPronatecEntities()
            : base("name=SysPronatecEntities")
        {
            
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Endereço> Endereço { get; set; }
        public DbSet<Escolaridade> Escolaridade { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
    }
}
