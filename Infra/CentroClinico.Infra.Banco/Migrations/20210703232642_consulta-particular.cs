using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Banco.Migrations
{
    public partial class consultaparticular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Particular",
                table: "consultas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Particular",
                table: "consultas");
        }
    }
}
