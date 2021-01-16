﻿using System;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=BW135\\SQLEXPRESS;Database=Heatmonitor;Trusted_Connection=True;");
            }
            */
        }
    }
}
