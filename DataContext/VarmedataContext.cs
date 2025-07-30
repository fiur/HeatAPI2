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
        public virtual DbSet<H24> H24 { get; set; }
        public virtual DbSet<Alarmnr> Alarmnr { get; set; }
        public virtual DbSet<Componoff> Componoff { get; set; }
        public virtual DbSet<Grmin> Grmin { get; set; }
        public virtual DbSet<Pprodvarme> Pprodvarme { get; set; }
        public virtual DbSet<Pprodvv> Pprodvv { get; set; }
        public virtual DbSet<Ptotude> Ptotude { get; set; }
        public virtual DbSet<Pude> Pude { get; set; }
        public virtual DbSet<Qcirc> Qcirc { get; set; }
        public virtual DbSet<Tfrainde> Tfrainde { get; set; }
        public virtual DbSet<Tfrember> Tfrember { get; set; }
        public virtual DbSet<Tfrem> Tfrem { get; set; }
        public virtual DbSet<Tinde> Tinde { get; set; }
        public virtual DbSet<Tretur> Tretur { get; set; }
        public virtual DbSet<Tstopude> Tstopude { get; set; }
        public virtual DbSet<Ttilinde> Ttilinde { get; set; }
        public virtual DbSet<Tude> Tude { get; set; }
        public virtual DbSet<Tvv> Tvv { get; set; }
        public virtual DbSet<Tzinde> Tzinde { get; set; }
        public virtual DbSet<Vkurve> Vkurve { get; set; }
        public virtual DbSet<Treturfordeler> Treturfordeler { get; set; }
        public virtual DbSet<Tfremfordeler> Tfremfordeler { get; set; }
        public virtual DbSet<Trumfordeler> Trumfordeler { get; set; }
        public virtual DbSet<Qcircradiator> Qcircradiator { get; set; }
        public virtual DbSet<Treturradiator> Treturradiator { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<H24>().HasNoKey();
            modelBuilder.Entity<TS>().HasNoKey();
            modelBuilder.Entity<Alarmnr>().ToTable("Alarmnr");
            modelBuilder.Entity<Componoff>().ToTable("Componoff");
            modelBuilder.Entity<Grmin>().ToTable("Grmin");
            modelBuilder.Entity<Pprodvarme>().ToTable("Pprodvarme");
            modelBuilder.Entity<Pprodvv>().ToTable("Pprodvv");
            modelBuilder.Entity<Ptotude>().ToTable("Ptotude");
            modelBuilder.Entity<Pude>().ToTable("Pude");
            modelBuilder.Entity<Qcirc>().ToTable("Qcirc");
            modelBuilder.Entity<Tfrainde>().ToTable("Tfrainde");
            modelBuilder.Entity<Tfrember>().ToTable("Tfrember");
            modelBuilder.Entity<Tfrem>().ToTable("Tfrem");
            modelBuilder.Entity<Tinde>().ToTable("Tinde");
            modelBuilder.Entity<Tretur>().ToTable("Tretur");
            modelBuilder.Entity<Tstopude>().ToTable("Tstopude");
            modelBuilder.Entity<Ttilinde>().ToTable("Ttilinde");
            modelBuilder.Entity<Tude>().ToTable("Tude");
            modelBuilder.Entity<Tvv>().ToTable("Tvv");
            modelBuilder.Entity<Tzinde>().ToTable("Tzinde");
            modelBuilder.Entity<Vkurve>().ToTable("Vkurve");
            modelBuilder.Entity<Treturfordeler>().ToTable("Treturfordeler");
            modelBuilder.Entity<Tfremfordeler>().ToTable("Tfremfordeler");
            modelBuilder.Entity<Treturradiator>().ToTable("Treturradiator");
            modelBuilder.Entity<Trumfordeler>().ToTable("Trumfordeler");
            modelBuilder.Entity<Qcircradiator>().ToTable("Qcircradiator");
        }
    }
}
