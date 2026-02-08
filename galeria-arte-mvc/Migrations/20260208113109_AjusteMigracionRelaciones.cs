using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace galeria_arte_mvc.Migrations
{
    /// <inheritdoc />
    public partial class AjusteMigracionRelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Obras_ArtistaId",
                table: "Obras",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_Artistas_ArtistaId",
                table: "Obras",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obras_Artistas_ArtistaId",
                table: "Obras");

            migrationBuilder.DropIndex(
                name: "IX_Obras_ArtistaId",
                table: "Obras");
        }
    }
}
