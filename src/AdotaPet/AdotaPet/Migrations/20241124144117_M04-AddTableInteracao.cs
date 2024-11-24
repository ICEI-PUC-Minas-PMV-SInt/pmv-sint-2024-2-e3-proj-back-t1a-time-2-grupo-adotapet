using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdotaPet.Migrations
{
    /// <inheritdoc />
    public partial class M04AddTableInteracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoInteracao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InteracaoAnuncio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InteracaoId = table.Column<int>(type: "int", nullable: false),
                    AnuncioId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteracaoAnuncio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InteracaoAnuncio_Anuncios_AnuncioId",
                        column: x => x.AnuncioId,
                        principalTable: "Anuncios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InteracaoAnuncio_Interacao_InteracaoId",
                        column: x => x.InteracaoId,
                        principalTable: "Interacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InteracaoAnuncio_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InteracaoAnuncio_AnuncioId",
                table: "InteracaoAnuncio",
                column: "AnuncioId");

            migrationBuilder.CreateIndex(
                name: "IX_InteracaoAnuncio_InteracaoId",
                table: "InteracaoAnuncio",
                column: "InteracaoId");

            migrationBuilder.CreateIndex(
                name: "IX_InteracaoAnuncio_UsuarioId",
                table: "InteracaoAnuncio",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InteracaoAnuncio");

            migrationBuilder.DropTable(
                name: "Interacao");
        }
    }
}
