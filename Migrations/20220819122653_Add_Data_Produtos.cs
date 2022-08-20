using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class Add_Data_Produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Produtos(Nome, Descricao, Estoque, ImageUrl, IdCategoria) values('Salada', 'Salada Gormet' 30, 'image.jpg', 1)");

            migrationBuilder.Sql("insert into Produtos(Nome, Descricao, Estoque, ImageUrl, IdCategoria) values('Hamburguer', 'Hamburguer Gormet' 30, 'image.jpg', 1)");

            migrationBuilder.Sql("insert into Produtos(Nome, Descricao, Estoque, ImageUrl, IdCategoria) values('Suco', 'Suco Gormet' 30, 'image.jpg', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Produtos");
        }
    }
}
