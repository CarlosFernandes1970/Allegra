using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;

#nullable disable

namespace Allegra.Migrations
{
    /// <inheritdoc />
    public partial class PopularJoias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Joias (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImgURL, ImgThumnail, IsPreferido, EmEstoque, CategoriaId) VALUES ('Brinco em meia lua', 'Em Ouro 8k', '10 brilhantes rosa e 10 brilhantes verdes. Tarracha em Ouro 8k', 250.00, 'image01.png', 'img02.png', 0, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Joias (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImgURL, ImgThumnail, IsPreferido, EmEstoque, CategoriaId) VALUES ('Anel Rococó', 'Em Ouro 8k', 'Meia aliança em em Ouro 8k com brilhantes', 470.00, 'image01.png', 'img02.png', 0, 1, 4)");
            migrationBuilder.Sql("INSERT INTO Joias (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImgURL, ImgThumnail, IsPreferido, EmEstoque, CategoriaId) VALUES ('Pulseira Olho Grago', 'Em Ouro 8k', 'Pulseira com pingente de Olho Grago Azul', 120.50, 'image01.png', 'img02.png', 0, 1, 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}








