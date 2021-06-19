﻿// <auto-generated />
using System;
using CentroClinico.Infra.Banco.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CentroClinico.Infra.Banco.Migrations
{
    [DbContext(typeof(EFContext))]
    partial class EFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Cliente", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("cliente_id");

                    b.Property<string>("NumeroCartaoConvenio")
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("numero_cartao_convenio");

                    b.Property<string>("Operadora")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("operadora");

                    b.Property<string>("Plano")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("plano");

                    b.Property<Guid>("UsuarioID")
                        .HasColumnType("char(36)")
                        .HasColumnName("usaurio_id");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Consulta", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("consulta_id");

                    b.Property<Guid>("ClienteID")
                        .HasColumnType("char(36)")
                        .HasColumnName("cliente_id");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_hora");

                    b.Property<Guid>("MedicoID")
                        .HasColumnType("char(36)")
                        .HasColumnName("medico_id");

                    b.Property<Guid>("UnidadeID")
                        .HasColumnType("char(36)")
                        .HasColumnName("unidade_id");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("MedicoID");

                    b.HasIndex("UnidadeID");

                    b.ToTable("consultas");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Consultorio", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("consultorio_id");

                    b.Property<int>("Andar")
                        .HasColumnType("int")
                        .HasColumnName("andar");

                    b.Property<int>("Sala")
                        .HasColumnType("int")
                        .HasColumnName("sala");

                    b.Property<Guid>("UnidadeID")
                        .HasColumnType("char(36)")
                        .HasColumnName("unidade_id");

                    b.HasKey("ID");

                    b.HasIndex("UnidadeID");

                    b.ToTable("consultorios");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Especialidade", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("especialidade_id");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("ID");

                    b.ToTable("especialidades");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Funcionario", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("funcionario_id");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("cep");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("complemento");

                    b.Property<string>("NumeroEndereco")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("numero_endereco");

                    b.Property<Guid>("UsuarioID")
                        .HasColumnType("char(36)")
                        .HasColumnName("usuario_id");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("funcionarios");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Medico", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("medico_id");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("crm");

                    b.Property<Guid>("UsuarioID")
                        .HasColumnType("char(36)")
                        .HasColumnName("usuario_id");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("medicos");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.MedicoEspecialidade", b =>
                {
                    b.Property<Guid>("EspecialidadeID")
                        .HasColumnType("char(36)")
                        .HasColumnName("especialidade_id");

                    b.Property<Guid>("MedicoID")
                        .HasColumnType("char(36)")
                        .HasColumnName("medico_id");

                    b.HasKey("EspecialidadeID", "MedicoID");

                    b.HasIndex("MedicoID");

                    b.ToTable("medico_especialidade");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.MedicoUnidade", b =>
                {
                    b.Property<Guid>("MedicoID")
                        .HasColumnType("char(36)")
                        .HasColumnName("medico_id");

                    b.Property<Guid>("UnidadeID")
                        .HasColumnType("char(36)")
                        .HasColumnName("unidade_id");

                    b.HasKey("MedicoID", "UnidadeID");

                    b.HasIndex("UnidadeID");

                    b.ToTable("medico_unidade");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Unidade", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("unidade_id");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("complemento");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("numero");

                    b.HasKey("ID");

                    b.ToTable("unidades");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("usuario_id");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("celular");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("nome");

                    b.Property<int>("Perfil")
                        .HasColumnType("int")
                        .HasColumnName("perfil");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("senha");

                    b.HasKey("ID");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Cliente", b =>
                {
                    b.HasOne("CentroClinico.Dominio.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Consulta", b =>
                {
                    b.HasOne("CentroClinico.Dominio.Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CentroClinico.Dominio.Entidades.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CentroClinico.Dominio.Entidades.Unidade", "Unidade")
                        .WithMany("Consultas")
                        .HasForeignKey("UnidadeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Medico");

                    b.Navigation("Unidade");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Consultorio", b =>
                {
                    b.HasOne("CentroClinico.Dominio.Entidades.Unidade", "Unidade")
                        .WithMany("Consultorios")
                        .HasForeignKey("UnidadeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unidade");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Funcionario", b =>
                {
                    b.HasOne("CentroClinico.Dominio.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Medico", b =>
                {
                    b.HasOne("CentroClinico.Dominio.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.MedicoEspecialidade", b =>
                {
                    b.HasOne("CentroClinico.Dominio.Entidades.Medico", "Medico")
                        .WithMany("Especialidades")
                        .HasForeignKey("EspecialidadeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CentroClinico.Dominio.Entidades.Especialidade", "Especialidade")
                        .WithMany("Medicos")
                        .HasForeignKey("MedicoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.MedicoUnidade", b =>
                {
                    b.HasOne("CentroClinico.Dominio.Entidades.Unidade", "Unidade")
                        .WithMany("Medicos")
                        .HasForeignKey("MedicoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CentroClinico.Dominio.Entidades.Medico", "Medico")
                        .WithMany("Unidades")
                        .HasForeignKey("UnidadeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Unidade");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Especialidade", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Medico", b =>
                {
                    b.Navigation("Especialidades");

                    b.Navigation("Unidades");
                });

            modelBuilder.Entity("CentroClinico.Dominio.Entidades.Unidade", b =>
                {
                    b.Navigation("Consultas");

                    b.Navigation("Consultorios");

                    b.Navigation("Medicos");
                });
#pragma warning restore 612, 618
        }
    }
}
