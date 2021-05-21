using Microsoft.EntityFrameworkCore.Migrations;

namespace SSC.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Nombre);
                });

            migrationBuilder.CreateTable(
                name: "Capitulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCurso = table.Column<int>(type: "int", nullable: false),
                    Tema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CursoNombre = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capitulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Capitulos_Cursos_CursoNombre",
                        column: x => x.CursoNombre,
                        principalTable: "Cursos",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EvaluacionesPracticas",
                columns: table => new
                {
                    NumeroEvaluacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aprobado = table.Column<bool>(type: "bit", nullable: false),
                    CursoNombre = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NombreCurso = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluacionesPracticas", x => x.NumeroEvaluacion);
                    table.ForeignKey(
                        name: "FK_EvaluacionesPracticas_Cursos_CursoNombre",
                        column: x => x.CursoNombre,
                        principalTable: "Cursos",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EvaluacionesTeoricas",
                columns: table => new
                {
                    NumeroEvaluacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calificacion = table.Column<int>(type: "int", nullable: false),
                    CursoNombre = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NombreCurso = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluacionesTeoricas", x => x.NumeroEvaluacion);
                    table.ForeignKey(
                        name: "FK_EvaluacionesTeoricas_Cursos_CursoNombre",
                        column: x => x.CursoNombre,
                        principalTable: "Cursos",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Capitulos_CursoNombre",
                table: "Capitulos",
                column: "CursoNombre");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesPracticas_CursoNombre",
                table: "EvaluacionesPracticas",
                column: "CursoNombre");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesTeoricas_CursoNombre",
                table: "EvaluacionesTeoricas",
                column: "CursoNombre");
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
