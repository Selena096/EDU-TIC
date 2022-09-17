using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduTic.App.Persistencia.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Actividad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreActividad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nota = table.Column<float>(type: "real", nullable: false),
                    archivoP = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    archivoE = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    materiasid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividad", x => x.id);
                    table.ForeignKey(
                        name: "FK_Actividad_Materia_materiasid",
                        column: x => x.materiasid,
                        principalTable: "Materia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    grado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    materiaEid = table.Column<int>(type: "int", nullable: true),
                    cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    materiaPid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.id);
                    table.ForeignKey(
                        name: "FK_Persona_Materia_materiaEid",
                        column: x => x.materiaEid,
                        principalTable: "Materia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Materia_materiaPid",
                        column: x => x.materiaPid,
                        principalTable: "Materia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividad_materiasid",
                table: "Actividad",
                column: "materiasid");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_materiaEid",
                table: "Persona",
                column: "materiaEid");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_materiaPid",
                table: "Persona",
                column: "materiaPid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividad");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Materia");
        }
    }
}
