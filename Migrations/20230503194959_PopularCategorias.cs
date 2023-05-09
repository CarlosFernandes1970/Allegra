using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Allegra.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao, Status) " +
                "VALUES('Brincos em Ouro', 'Brincos feitos em Ouro', '1')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao, Status) " +
                "VALUES('Colares em Prata', 'Colares feitos em prata', '1')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao, Status) " +
                 "VALUES('Pulseiras', 'Pulseiras feitos em prata', '1')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
