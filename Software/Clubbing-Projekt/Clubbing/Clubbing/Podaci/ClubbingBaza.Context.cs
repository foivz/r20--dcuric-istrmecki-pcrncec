﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clubbing.Podaci
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dogadjaj> Dogadjajs { get; set; }
        public virtual DbSet<Klub> Klubs { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Lokacija> Lokacijas { get; set; }
        public virtual DbSet<Obavijest> Obavijests { get; set; }
        public virtual DbSet<Prati> Pratis { get; set; }
        public virtual DbSet<Recenzija> Recenzijas { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
        public virtual DbSet<Slika> Slikas { get; set; }
        public virtual DbSet<StatusRezervacije> StatusRezervacijes { get; set; }
        public virtual DbSet<Stol> Stols { get; set; }
        public virtual DbSet<Zanr> Zanrs { get; set; }
    }
}
