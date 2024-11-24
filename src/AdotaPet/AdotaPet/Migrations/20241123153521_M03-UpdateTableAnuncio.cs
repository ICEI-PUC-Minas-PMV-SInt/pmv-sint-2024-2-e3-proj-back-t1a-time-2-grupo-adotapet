using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdotaPet.Migrations
{
    /// <inheritdoc />
    public partial class M03UpdateTableAnuncio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Raca",
                table: "Anuncios");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Anuncios",
                newName: "RacaAnimal");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Anuncios",
                newName: "IdadeAnimal");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaAnimal",
                table: "Anuncios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPostagem",
                table: "Anuncios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Anuncios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Anuncios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Anuncios_UsuarioId",
                table: "Anuncios",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anuncios_Usuarios_UsuarioId",
                table: "Anuncios",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anuncios_Usuarios_UsuarioId",
                table: "Anuncios");

            migrationBuilder.DropIndex(
                name: "IX_Anuncios_UsuarioId",
                table: "Anuncios");

            migrationBuilder.DropColumn(
                name: "CategoriaAnimal",
                table: "Anuncios");

            migrationBuilder.DropColumn(
                name: "DataPostagem",
                table: "Anuncios");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Anuncios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Anuncios");

            migrationBuilder.RenameColumn(
                name: "RacaAnimal",
                table: "Anuncios",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "IdadeAnimal",
                table: "Anuncios",
                newName: "Idade");

            migrationBuilder.AddColumn<string>(
                name: "Raca",
                table: "Anuncios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
