using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaServicios.Api.Autor.Migrations
{
    public partial class EliminarRelacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GradosMusicales_Cantantes_CantanteIdCantante",
                table: "GradosMusicales");

            migrationBuilder.DropIndex(
                name: "IX_GradosMusicales_CantanteIdCantante",
                table: "GradosMusicales");

            migrationBuilder.DropColumn(
                name: "CantanteIdCantante",
                table: "GradosMusicales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantanteIdCantante",
                table: "GradosMusicales",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GradosMusicales_CantanteIdCantante",
                table: "GradosMusicales",
                column: "CantanteIdCantante");

            migrationBuilder.AddForeignKey(
                name: "FK_GradosMusicales_Cantantes_CantanteIdCantante",
                table: "GradosMusicales",
                column: "CantanteIdCantante",
                principalTable: "Cantantes",
                principalColumn: "IdCantante",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
