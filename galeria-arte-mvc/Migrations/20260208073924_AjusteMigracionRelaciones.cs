using System;
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
            migrationBuilder.DropColumn(
                name: "AritstaId",
                table: "Obras");

            migrationBuilder.CreateTable(
                name: "ExposicionObra",
                columns: table => new
                {
                    ExposicionesObrasId = table.Column<int>(type: "int", nullable: false),
                    ObrasExpuestasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExposicionObra", x => new { x.ExposicionesObrasId, x.ObrasExpuestasId });
                    table.ForeignKey(
                        name: "FK_ExposicionObra_Exposiciones_ExposicionesObrasId",
                        column: x => x.ExposicionesObrasId,
                        principalTable: "Exposiciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExposicionObra_Obras_ObrasExpuestasId",
                        column: x => x.ObrasExpuestasId,
                        principalTable: "Obras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExposicionObra_ObrasExpuestasId",
                table: "ExposicionObra",
                column: "ObrasExpuestasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExposicionObra");

            migrationBuilder.AddColumn<string>(
                name: "AritstaId",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
