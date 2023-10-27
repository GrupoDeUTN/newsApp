using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newsApp.Migrations
{
    /// <inheritdoc />
    public partial class createnotificaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppNotificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mensajeDeTextoEncontrado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaAviso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppNotificaciones", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppNotificaciones");
        }
    }
}
