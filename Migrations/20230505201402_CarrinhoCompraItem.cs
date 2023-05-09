using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Allegra.Migrations
{
    /// <inheritdoc />
    public partial class CarrinhoCompraItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhoComprasItens",
                columns: table => new
                {
                    CarrinhoCompraItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JoiaId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoComprasItens", x => x.CarrinhoCompraItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoComprasItens_Joias_JoiaId",
                        column: x => x.JoiaId,
                        principalTable: "Joias",
                        principalColumn: "JoiaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoComprasItens_JoiaId",
                table: "CarrinhoComprasItens",
                column: "JoiaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoComprasItens");
        }
    }
}
