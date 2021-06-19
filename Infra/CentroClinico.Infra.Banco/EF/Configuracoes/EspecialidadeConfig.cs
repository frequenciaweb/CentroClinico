using CentroClinico.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Banco.EF.Configuracoes
{
    public class EspecialidadeConfig : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.ToTable("especialidades");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).HasColumnName("especialidade_id").ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50);

        }
    }
}
