using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Banco.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "especialidades",
                columns: table => new
                {
                    especialidade_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especialidades", x => x.especialidade_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "unidades",
                columns: table => new
                {
                    unidade_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    cep = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidade = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidades", x => x.unidade_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    usuario_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    celular = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    perfil = table.Column<int>(type: "int", nullable: false),
                    ativo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Nascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.usuario_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "consultorios",
                columns: table => new
                {
                    consultorio_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    sala = table.Column<int>(type: "int", nullable: false),
                    andar = table.Column<int>(type: "int", nullable: false),
                    unidade_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultorios", x => x.consultorio_id);
                    table.ForeignKey(
                        name: "FK_consultorios_unidades_unidade_id",
                        column: x => x.unidade_id,
                        principalTable: "unidades",
                        principalColumn: "unidade_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    cliente_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    numero_cartao_convenio = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operadora = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    plano = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usaurio_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.cliente_id);
                    table.ForeignKey(
                        name: "FK_clientes_usuarios_usaurio_id",
                        column: x => x.usaurio_id,
                        principalTable: "usuarios",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "funcionarios",
                columns: table => new
                {
                    funcionario_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    cpf = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cep = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero_endereco = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usuario_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios", x => x.funcionario_id);
                    table.ForeignKey(
                        name: "FK_funcionarios_usuarios_usuario_id",
                        column: x => x.usuario_id,
                        principalTable: "usuarios",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicos",
                columns: table => new
                {
                    medico_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    crm = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cpf = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usuario_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicos", x => x.medico_id);
                    table.ForeignKey(
                        name: "FK_medicos_usuarios_usuario_id",
                        column: x => x.usuario_id,
                        principalTable: "usuarios",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "consultas",
                columns: table => new
                {
                    consulta_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    medico_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_hora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    unidade_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    cliente_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    EspecialidadeID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Particular = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultas", x => x.consulta_id);
                    table.ForeignKey(
                        name: "FK_consultas_clientes_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "clientes",
                        principalColumn: "cliente_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_consultas_especialidades_EspecialidadeID",
                        column: x => x.EspecialidadeID,
                        principalTable: "especialidades",
                        principalColumn: "especialidade_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_consultas_medicos_medico_id",
                        column: x => x.medico_id,
                        principalTable: "medicos",
                        principalColumn: "medico_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_consultas_unidades_unidade_id",
                        column: x => x.unidade_id,
                        principalTable: "unidades",
                        principalColumn: "unidade_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medico_especialidade",
                columns: table => new
                {
                    medico_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    especialidade_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medico_especialidade", x => new { x.especialidade_id, x.medico_id });
                    table.ForeignKey(
                        name: "FK_medico_especialidade_especialidades_especialidade_id",
                        column: x => x.especialidade_id,
                        principalTable: "especialidades",
                        principalColumn: "especialidade_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medico_especialidade_medicos_medico_id",
                        column: x => x.medico_id,
                        principalTable: "medicos",
                        principalColumn: "medico_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medico_unidade",
                columns: table => new
                {
                    medico_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    unidade_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medico_unidade", x => new { x.medico_id, x.unidade_id });
                    table.ForeignKey(
                        name: "FK_medico_unidade_medicos_medico_id",
                        column: x => x.medico_id,
                        principalTable: "medicos",
                        principalColumn: "medico_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medico_unidade_unidades_unidade_id",
                        column: x => x.unidade_id,
                        principalTable: "unidades",
                        principalColumn: "unidade_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_clientes_usaurio_id",
                table: "clientes",
                column: "usaurio_id");

            migrationBuilder.CreateIndex(
                name: "IX_consultas_cliente_id",
                table: "consultas",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_consultas_EspecialidadeID",
                table: "consultas",
                column: "EspecialidadeID");

            migrationBuilder.CreateIndex(
                name: "IX_consultas_medico_id",
                table: "consultas",
                column: "medico_id");

            migrationBuilder.CreateIndex(
                name: "IX_consultas_unidade_id",
                table: "consultas",
                column: "unidade_id");

            migrationBuilder.CreateIndex(
                name: "IX_consultorios_unidade_id",
                table: "consultorios",
                column: "unidade_id");

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_usuario_id",
                table: "funcionarios",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_medico_especialidade_medico_id",
                table: "medico_especialidade",
                column: "medico_id");

            migrationBuilder.CreateIndex(
                name: "IX_medico_unidade_unidade_id",
                table: "medico_unidade",
                column: "unidade_id");

            migrationBuilder.CreateIndex(
                name: "IX_medicos_usuario_id",
                table: "medicos",
                column: "usuario_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "consultas");

            migrationBuilder.DropTable(
                name: "consultorios");

            migrationBuilder.DropTable(
                name: "funcionarios");

            migrationBuilder.DropTable(
                name: "medico_especialidade");

            migrationBuilder.DropTable(
                name: "medico_unidade");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "especialidades");

            migrationBuilder.DropTable(
                name: "medicos");

            migrationBuilder.DropTable(
                name: "unidades");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
