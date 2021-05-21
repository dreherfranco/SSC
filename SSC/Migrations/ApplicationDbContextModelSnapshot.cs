﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSC.DbConfiguration;

namespace SSC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SSC.Modelos.Capitulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CursoNombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombreCurso")
                        .HasColumnType("int");

                    b.Property<string>("Tema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CursoNombre");

                    b.ToTable("Capitulos");
                });

            modelBuilder.Entity("SSC.Modelos.Curso", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Instructor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nombre");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("SSC.Modelos.EvaluacionPractica", b =>
                {
                    b.Property<int>("NumeroEvaluacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aprobado")
                        .HasColumnType("bit");

                    b.Property<string>("CursoNombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NombreCurso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NumeroEvaluacion");

                    b.HasIndex("CursoNombre");

                    b.ToTable("EvaluacionesPracticas");
                });

            modelBuilder.Entity("SSC.Modelos.EvaluacionTeorica", b =>
                {
                    b.Property<int>("NumeroEvaluacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calificacion")
                        .HasColumnType("int");

                    b.Property<string>("CursoNombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NombreCurso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NumeroEvaluacion");

                    b.HasIndex("CursoNombre");

                    b.ToTable("EvaluacionesTeoricas");
                });

            modelBuilder.Entity("SSC.Modelos.Capitulo", b =>
                {
                    b.HasOne("SSC.Modelos.Curso", "Curso")
                        .WithMany("Capitulos")
                        .HasForeignKey("CursoNombre");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("SSC.Modelos.EvaluacionPractica", b =>
                {
                    b.HasOne("SSC.Modelos.Curso", "Curso")
                        .WithMany("EvaluacionesPracticas")
                        .HasForeignKey("CursoNombre");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("SSC.Modelos.EvaluacionTeorica", b =>
                {
                    b.HasOne("SSC.Modelos.Curso", "Curso")
                        .WithMany("EvaluacionesTeoricas")
                        .HasForeignKey("CursoNombre");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("SSC.Modelos.Curso", b =>
                {
                    b.Navigation("Capitulos");

                    b.Navigation("EvaluacionesPracticas");

                    b.Navigation("EvaluacionesTeoricas");
                });
#pragma warning restore 612, 618
        }
    }
}
