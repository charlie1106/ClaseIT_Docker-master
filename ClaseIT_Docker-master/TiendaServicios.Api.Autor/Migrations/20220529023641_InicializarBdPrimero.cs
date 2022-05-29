using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TiendaServicios.Api.Autor.Migrations
{
    public partial class InicializarBdPrimero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoresCanciones",
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
                    table.PrimaryKey("PK_AutoresCanciones", x => x.IdCantante);
                });

            migrationBuilder.CreateTable(
                name: "GradosMusicales",
                columns: table => new
                {
                    IdEscuelaMusica = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreEscuela = table.Column<string>(type: "text", nullable: false),
                    FechaGrado = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GradosMusicales = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradosMusicales", x => x.IdEscuelaMusica);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoresCanciones");

            migrationBuilder.DropTable(
                name: "GradosMusicales");
        }
    }
}
