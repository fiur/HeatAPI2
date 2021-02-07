using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HeatAPI.Models;

namespace HeatAPI.DataContext
{
    public partial class VarmedataContext : DbContext
    {
        public VarmedataContext()
        {
        }

        public VarmedataContext(DbContextOptions<VarmedataContext> options) : base(options)
        {
        }
        public virtual DbSet<Measurement> Measurement { get; set; }
        public virtual DbSet<TS> TS { get; set; }
        public virtual DbSet<Alarmer> Alarmer { get; set; }
        public virtual DbSet<Componoff> Componoff { get; set; }
        public virtual DbSet<Grmin> Grmin { get; set; }
        public virtual DbSet<Pprodvarme> Pprodvarme { get; set; }
        public virtual DbSet<Pprodvv> Pprodvv { get; set; }
        public virtual DbSet<Ptotude> Ptotude { get; set; }
        public virtual DbSet<Pude> Pude { get; set; }
        public virtual DbSet<Qcirc> Qcirc { get; set; }
        public virtual DbSet<Tfrainde> Tfrainde { get; set; }
        public virtual DbSet<Tfremberr> Tfremberr { get; set; }
        public virtual DbSet<Tfremr> Tfremr { get; set; }
        public virtual DbSet<Tinde> Tinde { get; set; }
        public virtual DbSet<Treturr> Treturr { get; set; }
        public virtual DbSet<Tstopude> Tstopude { get; set; }
        public virtual DbSet<Ttilinde> Ttilinde { get; set; }
        public virtual DbSet<Tude> Tude { get; set; }
        public virtual DbSet<Tvv> Tvv { get; set; }
        public virtual DbSet<Tzinde> Tzinde { get; set; }
        public virtual DbSet<Vkurve> Vkurve { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TS>().HasNoKey();
            modelBuilder.Entity<Alarmer>().ToTable("Alarmer");
            modelBuilder.Entity<Componoff>().ToTable("Componoff");
            modelBuilder.Entity<Grmin>().ToTable("Grmin");
            modelBuilder.Entity<Pprodvarme>().ToTable("Pprodvarme");
            modelBuilder.Entity<Pprodvv>().ToTable("Pprodvv");
            modelBuilder.Entity<Ptotude>().ToTable("Ptotude");
            modelBuilder.Entity<Pude>().ToTable("Pude");
            modelBuilder.Entity<Qcirc>().ToTable("Qcirc");
            modelBuilder.Entity<Tfrainde>().ToTable("Tfrainde");
            modelBuilder.Entity<Tfremberr>().ToTable("Tfremberr");
            modelBuilder.Entity<Tfremr>().ToTable("Tfremr");
            modelBuilder.Entity<Tinde>().ToTable("Tinde");
            modelBuilder.Entity<Treturr>().ToTable("Treturr");
            modelBuilder.Entity<Tstopude>().ToTable("Tstopude");
            modelBuilder.Entity<Ttilinde>().ToTable("Ttilinde");
            modelBuilder.Entity<Tude>().ToTable("Tude");
            modelBuilder.Entity<Tvv>().ToTable("Tvv");
            modelBuilder.Entity<Tzinde>().ToTable("Tzinde");
            modelBuilder.Entity<Vkurve>().ToTable("Vkurve");
        }
    }
}
