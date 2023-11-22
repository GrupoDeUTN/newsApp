using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newsApp.Migrations
{
    /// <inheritdoc />
    public partial class prueba2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TemaId",
                table: "AppTemas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "AppTemas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "AppNoticias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_AppTemas_TemaId",
                table: "AppTemas",
                column: "TemaId");

            migrationBuilder.CreateIndex(
                name: "IX_AppTemas_UserId",
                table: "AppTemas",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppTemas_AbpUsers_UserId",
                table: "AppTemas",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppTemas_AppTemas_TemaId",
                table: "AppTemas",
                column: "TemaId",
                principalTable: "AppTemas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppTemas_AbpUsers_UserId",
                table: "AppTemas");

            migrationBuilder.DropForeignKey(
                name: "FK_AppTemas_AppTemas_TemaId",
                table: "AppTemas");

            migrationBuilder.DropIndex(
                name: "IX_AppTemas_TemaId",
                table: "AppTemas");

            migrationBuilder.DropIndex(
                name: "IX_AppTemas_UserId",
                table: "AppTemas");

            migrationBuilder.DropColumn(
                name: "TemaId",
                table: "AppTemas");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AppTemas");

            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "AppNoticias");
        }
    }
}
