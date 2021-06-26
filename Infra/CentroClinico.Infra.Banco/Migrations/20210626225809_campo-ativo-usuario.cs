﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Banco.Migrations
{
    public partial class campoativousuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "usuarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ativo",
                table: "usuarios");
        }
    }
}
