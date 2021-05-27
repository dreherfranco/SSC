﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SSC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Costo = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Capitulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    Tema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capitulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Capitulos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluacionesPracticas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aprobado = table.Column<bool>(type: "bit", nullable: false),
                    NumeroEvaluacion = table.Column<int>(type: "int", nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluacionesPracticas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluacionesPracticas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluacionesTeoricas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calificacion = table.Column<int>(type: "int", nullable: false),
                    NumeroEvaluacion = table.Column<int>(type: "int", nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluacionesTeoricas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluacionesTeoricas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Costo", "Instructor", "Nombre" },
                values: new object[] { 1, 2000f, "Emanuel Goette", "NetCore" });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Costo", "Instructor", "Nombre" },
                values: new object[] { 2, 1500f, "Emanuel Goette", "Php" });

            migrationBuilder.InsertData(
                table: "Capitulos",
                columns: new[] { "Id", "CursoId", "Descripcion", "Tema" },
                values: new object[,]
                {
                    { 1, 1, "capitulo 1 del curso de net core", "POO" },
                    { 2, 1, "capitulo 2 del curso de net core", "AutoMapper" },
                    { 3, 2, "cap 1 curso PHP", "Variables" }
                });

            migrationBuilder.InsertData(
                table: "EvaluacionesPracticas",
                columns: new[] { "Id", "Aprobado", "CursoId", "NumeroEvaluacion" },
                values: new object[] { 1, true, 1, 2 });

            migrationBuilder.InsertData(
                table: "EvaluacionesTeoricas",
                columns: new[] { "Id", "Calificacion", "CursoId", "NumeroEvaluacion" },
                values: new object[] { 1, 68, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Capitulos_CursoId",
                table: "Capitulos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesPracticas_CursoId",
                table: "EvaluacionesPracticas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesTeoricas_CursoId",
                table: "EvaluacionesTeoricas",
                column: "CursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Capitulos");

            migrationBuilder.DropTable(
                name: "EvaluacionesPracticas");

            migrationBuilder.DropTable(
                name: "EvaluacionesTeoricas");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}