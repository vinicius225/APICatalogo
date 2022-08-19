using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class AddDataCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Categorias(Nome,ImageUrl)  values('Bebidas','Bebidas.Jpg')");
            migrationBuilder.Sql("insert into Categorias(Nome,ImageUrl)  values('Lanches','Lanches.Jpg')");
            migrationBuilder.Sql("insert into Categorias(Nome,ImageUrl)  values('Sobremesas','v.Jpg')");
            migrationBuilder.Sql("insert into Categorias(Nome,ImageUrl)  values('Aperitivos','Aperitivos.Jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Categorias");
        }
    }
}
