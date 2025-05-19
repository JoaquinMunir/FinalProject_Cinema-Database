using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class FixBoletoRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Boletos_IdFuncion",
                table: "Boletos",
                column: "IdFuncion");

            migrationBuilder.AddForeignKey(
                name: "FK_Boletos_Funciones_IdFuncion",
                table: "Boletos",
                column: "IdFuncion",
                principalTable: "Funciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boletos_Funciones_IdFuncion",
                table: "Boletos");

            migrationBuilder.DropIndex(
                name: "IX_Boletos_IdFuncion",
                table: "Boletos");
        }
    }
}
