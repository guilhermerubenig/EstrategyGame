﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StrategyGame.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StrategyGameEntities : DbContext
    {
        public StrategyGameEntities()
            : base("name=StrategyGameEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Gamer> Gamer { get; set; }
        public virtual DbSet<GamerGame> GamerGame { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Plataforma> Plataforma { get; set; }
        public virtual DbSet<GamerGrupo> GamerGrupo { get; set; }
        public virtual DbSet<GrupoGamer> GrupoGamer { get; set; }
        public virtual DbSet<Partidas> Partidas { get; set; }
        public virtual DbSet<PartidasResultado> PartidasResultado { get; set; }
        public virtual DbSet<PlataformaGame> PlataformaGame { get; set; }
        public virtual DbSet<TorneioGrupoGamer> TorneioGrupoGamer { get; set; }
        public virtual DbSet<Torneios> Torneios { get; set; }
    }
}