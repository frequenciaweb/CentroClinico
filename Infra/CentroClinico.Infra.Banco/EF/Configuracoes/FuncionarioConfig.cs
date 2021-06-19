using CentroClinico.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Banco.EF.Configuracoes
{
    public class FuncionarioConfig : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("funcionarios");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasColumnName("funcionario_id").ValueGeneratedOnAdd();


            builder.Property(x => x.CPF).HasColumnName("cpf").HasMaxLength(11).IsRequired();
            builder.Property(x => x.CEP).HasColumnName("cep").HasMaxLength(8).IsRequired();
            builder.Property(x => x.NumeroEndereco).HasColumnName("numero_endereco").HasMaxLength(10).IsRequired();
            builder.Property(x => x.Complemento).HasColumnName("complemento").HasMaxLength(50).IsRequired();
            builder.Property(x => x.UsuarioID).HasColumnName("usuario_id");

            builder.HasOne(x => x.Usuario);

         }
    }
}
