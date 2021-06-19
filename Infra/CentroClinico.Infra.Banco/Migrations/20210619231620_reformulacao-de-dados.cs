using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Banco.Migrations
{
    public partial class reformulacaodedados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Usuarios_UsuarioID",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Clientes_ClienteID",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Medicos_MedicoID",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Unidades_UnidadeID",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultorios_Unidades_UnidadeID",
                table: "Consultorios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Usuarios_UsuarioID",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoEspecialidades_Especialidades_EspecialidadeID",
                table: "MedicoEspecialidades");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoEspecialidades_Medicos_MedicoID",
                table: "MedicoEspecialidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Unidades_UnidadeID",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Usuarios_UsuarioID",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoUnidades_Medicos_MedicoID",
                table: "MedicoUnidades");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoUnidades_Unidades_UnidadeID",
                table: "MedicoUnidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unidades",
                table: "Unidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicos",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_UnidadeID",
                table: "Medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultorios",
                table: "Consultorios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicoUnidades",
                table: "MedicoUnidades");

            migrationBuilder.DropIndex(
                name: "IX_MedicoUnidades_MedicoID",
                table: "MedicoUnidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicoEspecialidades",
                table: "MedicoEspecialidades");

            migrationBuilder.DropIndex(
                name: "IX_MedicoEspecialidades_EspecialidadeID",
                table: "MedicoEspecialidades");

            migrationBuilder.DropColumn(
                name: "UnidadeID",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "MedicoUnidades");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "MedicoEspecialidades");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "usuarios");

            migrationBuilder.RenameTable(
                name: "Unidades",
                newName: "unidades");

            migrationBuilder.RenameTable(
                name: "Medicos",
                newName: "medicos");

            migrationBuilder.RenameTable(
                name: "Funcionarios",
                newName: "funcionarios");

            migrationBuilder.RenameTable(
                name: "Especialidades",
                newName: "especialidades");

            migrationBuilder.RenameTable(
                name: "Consultorios",
                newName: "consultorios");

            migrationBuilder.RenameTable(
                name: "Consultas",
                newName: "consultas");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "clientes");

            migrationBuilder.RenameTable(
                name: "MedicoUnidades",
                newName: "medico_unidade");

            migrationBuilder.RenameTable(
                name: "MedicoEspecialidades",
                newName: "medico_especialidade");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "usuarios",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "Perfil",
                table: "usuarios",
                newName: "perfil");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "usuarios",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "usuarios",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "usuarios",
                newName: "celular");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "usuarios",
                newName: "usuario_id");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "unidades",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "unidades",
                newName: "complemento");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "unidades",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "CEP",
                table: "unidades",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "unidades",
                newName: "unidade_id");

            migrationBuilder.RenameColumn(
                name: "CRM",
                table: "medicos",
                newName: "crm");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "medicos",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "UsuarioID",
                table: "medicos",
                newName: "usuario_id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "medicos",
                newName: "medico_id");

            migrationBuilder.RenameIndex(
                name: "IX_Medicos_UsuarioID",
                table: "medicos",
                newName: "IX_medicos_usuario_id");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "funcionarios",
                newName: "complemento");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "funcionarios",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "CEP",
                table: "funcionarios",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "UsuarioID",
                table: "funcionarios",
                newName: "usuario_id");

            migrationBuilder.RenameColumn(
                name: "NumeroEndereco",
                table: "funcionarios",
                newName: "numero_endereco");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "funcionarios",
                newName: "funcionario_id");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionarios_UsuarioID",
                table: "funcionarios",
                newName: "IX_funcionarios_usuario_id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "especialidades",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "especialidades",
                newName: "especialidade_id");

            migrationBuilder.RenameColumn(
                name: "Sala",
                table: "consultorios",
                newName: "sala");

            migrationBuilder.RenameColumn(
                name: "Andar",
                table: "consultorios",
                newName: "andar");

            migrationBuilder.RenameColumn(
                name: "UnidadeID",
                table: "consultorios",
                newName: "unidade_id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "consultorios",
                newName: "consultorio_id");

            migrationBuilder.RenameIndex(
                name: "IX_Consultorios_UnidadeID",
                table: "consultorios",
                newName: "IX_consultorios_unidade_id");

            migrationBuilder.RenameColumn(
                name: "UnidadeID",
                table: "consultas",
                newName: "unidade_id");

            migrationBuilder.RenameColumn(
                name: "MedicoID",
                table: "consultas",
                newName: "medico_id");

            migrationBuilder.RenameColumn(
                name: "DataHora",
                table: "consultas",
                newName: "data_hora");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "consultas",
                newName: "cliente_id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "consultas",
                newName: "consulta_id");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_UnidadeID",
                table: "consultas",
                newName: "IX_consultas_unidade_id");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_MedicoID",
                table: "consultas",
                newName: "IX_consultas_medico_id");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_ClienteID",
                table: "consultas",
                newName: "IX_consultas_cliente_id");

            migrationBuilder.RenameColumn(
                name: "Plano",
                table: "clientes",
                newName: "plano");

            migrationBuilder.RenameColumn(
                name: "Operadora",
                table: "clientes",
                newName: "operadora");

            migrationBuilder.RenameColumn(
                name: "UsuarioID",
                table: "clientes",
                newName: "usaurio_id");

            migrationBuilder.RenameColumn(
                name: "NumeroCartaoConvenio",
                table: "clientes",
                newName: "numero_cartao_convenio");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "clientes",
                newName: "cliente_id");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_UsuarioID",
                table: "clientes",
                newName: "IX_clientes_usaurio_id");

            migrationBuilder.RenameColumn(
                name: "UnidadeID",
                table: "medico_unidade",
                newName: "unidade_id");

            migrationBuilder.RenameColumn(
                name: "MedicoID",
                table: "medico_unidade",
                newName: "medico_id");

            migrationBuilder.RenameIndex(
                name: "IX_MedicoUnidades_UnidadeID",
                table: "medico_unidade",
                newName: "IX_medico_unidade_unidade_id");

            migrationBuilder.RenameColumn(
                name: "MedicoID",
                table: "medico_especialidade",
                newName: "medico_id");

            migrationBuilder.RenameColumn(
                name: "EspecialidadeID",
                table: "medico_especialidade",
                newName: "especialidade_id");

            migrationBuilder.RenameIndex(
                name: "IX_MedicoEspecialidades_MedicoID",
                table: "medico_especialidade",
                newName: "IX_medico_especialidade_medico_id");

            migrationBuilder.AlterColumn<string>(
                name: "senha",
                table: "usuarios",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "usuarios",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "usuarios",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "usuarios",
                type: "varchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "unidades",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "unidades",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "unidades",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "unidades",
                type: "varchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "crm",
                table: "medicos",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "medicos",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "funcionarios",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "funcionarios",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "funcionarios",
                type: "varchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "numero_endereco",
                table: "funcionarios",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "especialidades",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "plano",
                table: "clientes",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "operadora",
                table: "clientes",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "numero_cartao_convenio",
                table: "clientes",
                type: "varchar(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "usuario_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_unidades",
                table: "unidades",
                column: "unidade_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medicos",
                table: "medicos",
                column: "medico_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_funcionarios",
                table: "funcionarios",
                column: "funcionario_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_especialidades",
                table: "especialidades",
                column: "especialidade_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_consultorios",
                table: "consultorios",
                column: "consultorio_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_consultas",
                table: "consultas",
                column: "consulta_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientes",
                table: "clientes",
                column: "cliente_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medico_unidade",
                table: "medico_unidade",
                columns: new[] { "medico_id", "unidade_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_medico_especialidade",
                table: "medico_especialidade",
                columns: new[] { "especialidade_id", "medico_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_usuarios_usaurio_id",
                table: "clientes",
                column: "usaurio_id",
                principalTable: "usuarios",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_consultas_clientes_cliente_id",
                table: "consultas",
                column: "cliente_id",
                principalTable: "clientes",
                principalColumn: "cliente_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_consultas_medicos_medico_id",
                table: "consultas",
                column: "medico_id",
                principalTable: "medicos",
                principalColumn: "medico_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_consultas_unidades_unidade_id",
                table: "consultas",
                column: "unidade_id",
                principalTable: "unidades",
                principalColumn: "unidade_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_consultorios_unidades_unidade_id",
                table: "consultorios",
                column: "unidade_id",
                principalTable: "unidades",
                principalColumn: "unidade_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_funcionarios_usuarios_usuario_id",
                table: "funcionarios",
                column: "usuario_id",
                principalTable: "usuarios",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medico_especialidade_especialidades_medico_id",
                table: "medico_especialidade",
                column: "medico_id",
                principalTable: "especialidades",
                principalColumn: "especialidade_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medico_especialidade_medicos_especialidade_id",
                table: "medico_especialidade",
                column: "especialidade_id",
                principalTable: "medicos",
                principalColumn: "medico_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medico_unidade_medicos_unidade_id",
                table: "medico_unidade",
                column: "unidade_id",
                principalTable: "medicos",
                principalColumn: "medico_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medico_unidade_unidades_medico_id",
                table: "medico_unidade",
                column: "medico_id",
                principalTable: "unidades",
                principalColumn: "unidade_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medicos_usuarios_usuario_id",
                table: "medicos",
                column: "usuario_id",
                principalTable: "usuarios",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_usuarios_usaurio_id",
                table: "clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_consultas_clientes_cliente_id",
                table: "consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_consultas_medicos_medico_id",
                table: "consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_consultas_unidades_unidade_id",
                table: "consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_consultorios_unidades_unidade_id",
                table: "consultorios");

            migrationBuilder.DropForeignKey(
                name: "FK_funcionarios_usuarios_usuario_id",
                table: "funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_medico_especialidade_especialidades_medico_id",
                table: "medico_especialidade");

            migrationBuilder.DropForeignKey(
                name: "FK_medico_especialidade_medicos_especialidade_id",
                table: "medico_especialidade");

            migrationBuilder.DropForeignKey(
                name: "FK_medico_unidade_medicos_unidade_id",
                table: "medico_unidade");

            migrationBuilder.DropForeignKey(
                name: "FK_medico_unidade_unidades_medico_id",
                table: "medico_unidade");

            migrationBuilder.DropForeignKey(
                name: "FK_medicos_usuarios_usuario_id",
                table: "medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_unidades",
                table: "unidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medicos",
                table: "medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_funcionarios",
                table: "funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_especialidades",
                table: "especialidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_consultorios",
                table: "consultorios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_consultas",
                table: "consultas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clientes",
                table: "clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medico_unidade",
                table: "medico_unidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medico_especialidade",
                table: "medico_especialidade");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "unidades",
                newName: "Unidades");

            migrationBuilder.RenameTable(
                name: "medicos",
                newName: "Medicos");

            migrationBuilder.RenameTable(
                name: "funcionarios",
                newName: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "especialidades",
                newName: "Especialidades");

            migrationBuilder.RenameTable(
                name: "consultorios",
                newName: "Consultorios");

            migrationBuilder.RenameTable(
                name: "consultas",
                newName: "Consultas");

            migrationBuilder.RenameTable(
                name: "clientes",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "medico_unidade",
                newName: "MedicoUnidades");

            migrationBuilder.RenameTable(
                name: "medico_especialidade",
                newName: "MedicoEspecialidades");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "Usuarios",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "perfil",
                table: "Usuarios",
                newName: "Perfil");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Usuarios",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "celular",
                table: "Usuarios",
                newName: "Celular");

            migrationBuilder.RenameColumn(
                name: "usuario_id",
                table: "Usuarios",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "Unidades",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "complemento",
                table: "Unidades",
                newName: "Complemento");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Unidades",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Unidades",
                newName: "CEP");

            migrationBuilder.RenameColumn(
                name: "unidade_id",
                table: "Unidades",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "crm",
                table: "Medicos",
                newName: "CRM");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Medicos",
                newName: "CPF");

            migrationBuilder.RenameColumn(
                name: "usuario_id",
                table: "Medicos",
                newName: "UsuarioID");

            migrationBuilder.RenameColumn(
                name: "medico_id",
                table: "Medicos",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_medicos_usuario_id",
                table: "Medicos",
                newName: "IX_Medicos_UsuarioID");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Funcionarios",
                newName: "CPF");

            migrationBuilder.RenameColumn(
                name: "complemento",
                table: "Funcionarios",
                newName: "Complemento");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Funcionarios",
                newName: "CEP");

            migrationBuilder.RenameColumn(
                name: "usuario_id",
                table: "Funcionarios",
                newName: "UsuarioID");

            migrationBuilder.RenameColumn(
                name: "numero_endereco",
                table: "Funcionarios",
                newName: "NumeroEndereco");

            migrationBuilder.RenameColumn(
                name: "funcionario_id",
                table: "Funcionarios",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_funcionarios_usuario_id",
                table: "Funcionarios",
                newName: "IX_Funcionarios_UsuarioID");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Especialidades",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "especialidade_id",
                table: "Especialidades",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "sala",
                table: "Consultorios",
                newName: "Sala");

            migrationBuilder.RenameColumn(
                name: "andar",
                table: "Consultorios",
                newName: "Andar");

            migrationBuilder.RenameColumn(
                name: "unidade_id",
                table: "Consultorios",
                newName: "UnidadeID");

            migrationBuilder.RenameColumn(
                name: "consultorio_id",
                table: "Consultorios",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_consultorios_unidade_id",
                table: "Consultorios",
                newName: "IX_Consultorios_UnidadeID");

            migrationBuilder.RenameColumn(
                name: "unidade_id",
                table: "Consultas",
                newName: "UnidadeID");

            migrationBuilder.RenameColumn(
                name: "medico_id",
                table: "Consultas",
                newName: "MedicoID");

            migrationBuilder.RenameColumn(
                name: "data_hora",
                table: "Consultas",
                newName: "DataHora");

            migrationBuilder.RenameColumn(
                name: "cliente_id",
                table: "Consultas",
                newName: "ClienteID");

            migrationBuilder.RenameColumn(
                name: "consulta_id",
                table: "Consultas",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_consultas_unidade_id",
                table: "Consultas",
                newName: "IX_Consultas_UnidadeID");

            migrationBuilder.RenameIndex(
                name: "IX_consultas_medico_id",
                table: "Consultas",
                newName: "IX_Consultas_MedicoID");

            migrationBuilder.RenameIndex(
                name: "IX_consultas_cliente_id",
                table: "Consultas",
                newName: "IX_Consultas_ClienteID");

            migrationBuilder.RenameColumn(
                name: "plano",
                table: "Clientes",
                newName: "Plano");

            migrationBuilder.RenameColumn(
                name: "operadora",
                table: "Clientes",
                newName: "Operadora");

            migrationBuilder.RenameColumn(
                name: "usaurio_id",
                table: "Clientes",
                newName: "UsuarioID");

            migrationBuilder.RenameColumn(
                name: "numero_cartao_convenio",
                table: "Clientes",
                newName: "NumeroCartaoConvenio");

            migrationBuilder.RenameColumn(
                name: "cliente_id",
                table: "Clientes",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_clientes_usaurio_id",
                table: "Clientes",
                newName: "IX_Clientes_UsuarioID");

            migrationBuilder.RenameColumn(
                name: "unidade_id",
                table: "MedicoUnidades",
                newName: "UnidadeID");

            migrationBuilder.RenameColumn(
                name: "medico_id",
                table: "MedicoUnidades",
                newName: "MedicoID");

            migrationBuilder.RenameIndex(
                name: "IX_medico_unidade_unidade_id",
                table: "MedicoUnidades",
                newName: "IX_MedicoUnidades_UnidadeID");

            migrationBuilder.RenameColumn(
                name: "medico_id",
                table: "MedicoEspecialidades",
                newName: "MedicoID");

            migrationBuilder.RenameColumn(
                name: "especialidade_id",
                table: "MedicoEspecialidades",
                newName: "EspecialidadeID");

            migrationBuilder.RenameIndex(
                name: "IX_medico_especialidade_medico_id",
                table: "MedicoEspecialidades",
                newName: "IX_MedicoEspecialidades_MedicoID");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldMaxLength: 60)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(12)",
                oldMaxLength: 12)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Unidades",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Unidades",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Unidades",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Unidades",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8)",
                oldMaxLength: 8)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CRM",
                table: "Medicos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Medicos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldMaxLength: 11)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UnidadeID",
                table: "Medicos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Funcionarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldMaxLength: 11)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Funcionarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Funcionarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8)",
                oldMaxLength: 8)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroEndereco",
                table: "Funcionarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Especialidades",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Plano",
                table: "Clientes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Operadora",
                table: "Clientes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroCartaoConvenio",
                table: "Clientes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "MedicoUnidades",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "MedicoEspecialidades",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unidades",
                table: "Unidades",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicos",
                table: "Medicos",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especialidades",
                table: "Especialidades",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultorios",
                table: "Consultorios",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicoUnidades",
                table: "MedicoUnidades",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicoEspecialidades",
                table: "MedicoEspecialidades",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_UnidadeID",
                table: "Medicos",
                column: "UnidadeID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoUnidades_MedicoID",
                table: "MedicoUnidades",
                column: "MedicoID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoEspecialidades_EspecialidadeID",
                table: "MedicoEspecialidades",
                column: "EspecialidadeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Usuarios_UsuarioID",
                table: "Clientes",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Clientes_ClienteID",
                table: "Consultas",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Medicos_MedicoID",
                table: "Consultas",
                column: "MedicoID",
                principalTable: "Medicos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Unidades_UnidadeID",
                table: "Consultas",
                column: "UnidadeID",
                principalTable: "Unidades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultorios_Unidades_UnidadeID",
                table: "Consultorios",
                column: "UnidadeID",
                principalTable: "Unidades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Usuarios_UsuarioID",
                table: "Funcionarios",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoEspecialidades_Especialidades_EspecialidadeID",
                table: "MedicoEspecialidades",
                column: "EspecialidadeID",
                principalTable: "Especialidades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoEspecialidades_Medicos_MedicoID",
                table: "MedicoEspecialidades",
                column: "MedicoID",
                principalTable: "Medicos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Unidades_UnidadeID",
                table: "Medicos",
                column: "UnidadeID",
                principalTable: "Unidades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Usuarios_UsuarioID",
                table: "Medicos",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoUnidades_Medicos_MedicoID",
                table: "MedicoUnidades",
                column: "MedicoID",
                principalTable: "Medicos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoUnidades_Unidades_UnidadeID",
                table: "MedicoUnidades",
                column: "UnidadeID",
                principalTable: "Unidades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
