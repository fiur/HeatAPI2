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

        public VarmedataContext(DbContextOptions<VarmedataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dummy> Dummy { get; set; }
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
                optionsBuilder.UseSqlServer("Server=ACERSERVER\\SQLEXPRESS;Database=Heatmonitor;Trusted_Connection=True;");
            }
            */
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Dummy>(entity =>
            {
                entity.ToTable("Dummy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });


            modelBuilder.Entity<Alarmer>(entity =>
            {
                entity.ToTable("alarmer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Componoff>(entity =>
            {
                entity.ToTable("componoff");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Grmin>(entity =>
            {
                entity.ToTable("grmin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Pprodvarme>(entity =>
            {
                entity.ToTable("pprodvarme");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Pprodvv>(entity =>
            {
                entity.ToTable("pprodvv");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Ptotude>(entity =>
            {
                entity.ToTable("ptotude");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Pude>(entity =>
            {
                entity.ToTable("pude");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Qcirc>(entity =>
            {
                entity.ToTable("qcirc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Tfrainde>(entity =>
            {
                entity.ToTable("tfrainde");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Tfremberr>(entity =>
            {
                entity.ToTable("tfremberr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Tfremr>(entity =>
            {
                entity.ToTable("tfremr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Tinde>(entity =>
            {
                entity.ToTable("tinde");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Treturr>(entity =>
            {
                entity.ToTable("treturr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Tstopude>(entity =>
            {
                entity.ToTable("tstopude");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Ttilinde>(entity =>
            {
                entity.ToTable("ttilinde");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Tude>(entity =>
            {
                entity.ToTable("tude");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Tvv>(entity =>
            {
                entity.ToTable("tvv");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Tzinde>(entity =>
            {
                entity.ToTable("tzinde");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });

            modelBuilder.Entity<Vkurve>(entity =>
            {
                entity.ToTable("vkurve");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
                entity.Ignore(e => e.Name);
                entity.Ignore(e => e.Unit);
                entity.Ignore(e => e.Controllable);
            });
        }
    }
}
