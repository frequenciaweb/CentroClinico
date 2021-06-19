using CentroClinico.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Banco.EF.Configuracoes
{
    public class UnidadeConfig : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.ToTable("unidades");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).HasColumnName("unidade_id");
            builder.Property(x => x.CEP).HasColumnName("cep").HasMaxLength(8).IsRequired();
            builder.Property(x => x.Complemento).HasColumnName("complemento").HasMaxLength(50);
            builder.Property(x => x.Numero).HasColumnName("numero").HasMaxLength(15).IsRequired();
            builder.Property(x => x.Cidade).HasColumnName("cidade").HasMaxLength(30).IsRequired();


        }
    }
}
