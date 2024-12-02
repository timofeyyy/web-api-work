﻿using app.Entities;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace app.Context
{
    public class DataBase : DbContext
    {
        public DbSet<Capacitors> Capacitors { get; set; }
        public DbSet<Resistors> Resistors { get; set; }
        public DbSet<Diods> Diods { get; set; }
        public DbSet<Microchips> Microchips { get; set; }
        public DbSet<Transistors> Transistors { get; set; }
        public DbSet<Technologies> Technologies { get; set; }
        public DbSet<Manufacturers> Manufacturers { get; set; }
        public DbSet<ComponentKinds> ComponentKinds { get; set; }
        public DbSet<ComponentTypes> ComponentTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=tcp:127.0.0.1,1433;Initial Catalog=master;Persist Security Info=False;User ID=HP;Password=Z183I2196B!N%W!X1Gi@YStV4v96QJxT@X*&I&4C!&ZC86L0!y;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            optionsBuilder.UseSqlServer(@"Data Source=Timofey\SQLEXPRESS;Database=ComponentDB;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Capacitors>()
            .Property(p => p.DocID)
            .HasColumnType("bigint");

            modelBuilder.Entity<Capacitors>()
            .Property(p => p.MinVoltage)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );

            modelBuilder.Entity<Capacitors>()
            .Property(p => p.MaxVoltage)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );

            modelBuilder.Entity<Capacitors>()
            .Property(p => p.MaxCapacity)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );

            modelBuilder.Entity<Capacitors>()
            .Property(p => p.MinCapacity)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );

            modelBuilder.Entity<Capacitors>()
            .Property(p => p.MinOperatingTemperature)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );

            modelBuilder.Entity<Capacitors>()
            .Property(p => p.MaxOperatingTemperature)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );

            modelBuilder.Entity<Capacitors>()
            .Property(p => p.AcceptableCapacityIncrease)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );

            modelBuilder.Entity<Capacitors>()
            .Property(p => p.AcceptableСapacityReduction)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );




            modelBuilder.Entity<Diods>()
               .Property(p => p.DocID)
               .HasColumnType("bigint");


            modelBuilder.Entity<Diods>()
            .Property(p => p.MaxPermissibleDCVoltage)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );

            modelBuilder.Entity<Diods>()
            .Property(p => p.MinOperatingTemperature)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );

            modelBuilder.Entity<Diods>()
            .Property(p => p.MaxOperatingTemperature)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );
           
            modelBuilder.Entity<Diods>()
            .Property(p => p.MaxPermissibleAverageDirectCurrent)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );
                   
            modelBuilder.Entity<Diods>()
            .Property(p => p.MaxiPermissibleDirectCurrent)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );

            modelBuilder.Entity<Diods>()
            .Property(p => p.RadiationResistance)
            .HasColumnType("float")
            .HasConversion(
                 v => v,
                 v => v != null ? (double)v : null
            );



            modelBuilder.Entity<Transistors>()
           .Property(p => p.DocID)
           .HasColumnType("bigint");

            modelBuilder.Entity<Transistors>()
           .Property(p => p.MaxPermissibleDCVoltage)
           .HasColumnType("float")
           .HasConversion(
                v => v, 
                v => v != null ? (double)v : null 
           );
            
            modelBuilder.Entity<Transistors>()
           .Property(p => p.MinOperatingTemperature)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );
            
            modelBuilder.Entity<Transistors>()
           .Property(p => p.RadiationResistance)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );
            
            modelBuilder.Entity<Transistors>()
           .Property(p => p.MaxOperatingTemperature)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
            );
            
            modelBuilder.Entity<Transistors>()
           .Property(p => p.MaxPermissibleDCCollectorCurrent)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
            );
             
          
            modelBuilder.Entity<Resistors>()
           .Property(p => p.DocID)
           .HasColumnType("bigint");

            modelBuilder.Entity<Resistors>()
           .Property(p => p.PowerRating)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );
            
            modelBuilder.Entity<Resistors>()
           .Property(p => p.MinVoltage)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );


           modelBuilder.Entity<Resistors>()
           .Property(p => p.MaxVoltage)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
            );

           modelBuilder.Entity<Resistors>()
           .Property(p => p.MinRatedResistance)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );

           modelBuilder.Entity<Resistors>()
           .Property(p => p.MaxRatedResistance)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );

           modelBuilder.Entity<Resistors>()
           .Property(p => p.ResistanceTolerance)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );

           modelBuilder.Entity<Resistors>()
           .Property(p => p.MinOperatingTemperature)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );

           modelBuilder.Entity<Resistors>()
           .Property(p => p.MaxOperatingTemperature)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );

           modelBuilder.Entity<Resistors>()
           .Property(p => p.CurrentLimit)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );


            modelBuilder.Entity<Microchips>()
           .Property(p => p.DocID)
           .HasColumnType("bigint");

            modelBuilder.Entity<Microchips>()
           .Property(p => p.MinVoltage)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => (double)v
           );

           modelBuilder.Entity<Microchips>()
           .Property(p => p.MaxVoltage)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => (double)v
           );

           modelBuilder.Entity<Microchips>()
           .Property(p => p.Frequency)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );

           modelBuilder.Entity<Microchips>()
           .Property(p => p.ConsumptionCurrent)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );

           modelBuilder.Entity<Microchips>()
           .Property(p => p.MinOperatingTemperature)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => (double)v
           );
            
           modelBuilder.Entity<Microchips>()
           .Property(p => p.MaxOperatingTemperature)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => (double)v
           );

           modelBuilder.Entity<Microchips>()
           .Property(p => p.RadiationResistance)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );

           modelBuilder.Entity<Microchips>()
           .Property(p => p.SamplingTime)
           .HasColumnType("float")
           .HasConversion(
                v => v,
                v => v != null ? (double)v : null
           );
        }
    }
}
