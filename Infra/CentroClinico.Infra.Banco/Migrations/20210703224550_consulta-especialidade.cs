using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Banco.Migrations
{
    public partial class consultaespecialidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EspecialidadeID",
                table: "consultas",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_consultas_EspecialidadeID",
                table: "consultas",
                column: "EspecialidadeID");

            migrationBuilder.AddForeignKey(
                name: "FK_consultas_especialidades_EspecialidadeID",
                table: "consultas",
                column: "EspecialidadeID",
                principalTable: "especialidades",
                principalColumn: "especialidade_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_consultas_especialidades_EspecialidadeID",
                table: "consultas");

            migrationBuilder.DropIndex(
                name: "IX_consultas_EspecialidadeID",
                table: "consultas");

            migrationBuilder.DropColumn(
                name: "EspecialidadeID",
                table: "consultas");
        }
    }
}
