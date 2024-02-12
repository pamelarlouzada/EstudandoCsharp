using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesFilmes.Migrations
{
    public partial class adicionandoavaliacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Avaliacao",
                table: "Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avaliacao",
                table: "Filme");
        }
    }
}
