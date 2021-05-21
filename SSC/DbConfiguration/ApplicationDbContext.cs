using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSC.Modelos;

namespace SSC.DbConfiguration
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Capitulo> Capitulos { get; set; }
        public DbSet<EvaluacionPractica> EvaluacionesPracticas { get; set; }
        public DbSet<EvaluacionTeorica> EvaluacionesTeoricas { get; set; }

        public ApplicationDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=.\SQLEXPRESS_2019;Initial Catalog=SSC;Integrated Security=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasKey(x => new { x.Nombre });

            modelBuilder.Entity<EvaluacionPractica>()
                .HasKey(x => new { x.NumeroEvaluacion });
            modelBuilder.Entity<EvaluacionTeorica>()
                .HasKey(x => new { x.NumeroEvaluacion });
            //SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

       // private void SeedData(ModelBuilder modelBuilder)
      //  {
            //CREAR DATA DE PRUEBA
      //  }

    }
}
