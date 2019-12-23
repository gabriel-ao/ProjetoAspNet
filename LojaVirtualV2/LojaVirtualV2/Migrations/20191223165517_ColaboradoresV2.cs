using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtualV2.Migrations
{
    public partial class ColaboradoresV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Colaboradores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Colaboradores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Colaboradores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Colaboradores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Colaboradores");
        }
    }
}
