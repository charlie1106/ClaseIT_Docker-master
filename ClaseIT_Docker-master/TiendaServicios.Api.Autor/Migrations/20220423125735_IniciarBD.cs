using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TiendaServicios.Api.Autor.Migrations
{
    public partial class IniciarBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cantantes",
                columns: table => new
                {
                    IdCantante = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Apellido = table.Column<string>(type: "text", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cantantes", x => x.IdCantante);
                });

            migrationBuilder.CreateTable(
                name: "GradosMusicales",
                columns: table => new
                {
                    IdEscuelaMusica = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CantanteIdCantante = table.Column<int>(type: "integer", nullable: false),
                    NombreEscuela = table.Column<string>(type: "text", nullable: false),
                    FechaGrado = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GradosMusicales = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradosMusicales", x => x.IdEscuelaMusica);
                    table.ForeignKey(
                        name: "FK_GradosMusicales_Cantantes_CantanteIdCantante",
                        column: x => x.CantanteIdCantante,
                        principalTable: "Cantantes",
                        principalColumn: "IdCantante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GradosMusicales_CantanteIdCantante",
                table: "GradosMusicales",
                column: "CantanteIdCantante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GradosMusicales");

            migrationBuilder.DropTable(
                name: "Cantantes");
        }
    }
}
