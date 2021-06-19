using CentroClinico.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Banco.EF.Configuracoes
{
    public class MedicoUnidadeConfig : IEntityTypeConfiguration<MedicoUnidade>
    {
        public void Configure(EntityTypeBuilder<MedicoUnidade> builder)
        {
            builder.ToTable("medico_unidade");
            builder.HasKey(x => new { x.MedicoID, x.UnidadeID });

            builder.Property(x => x.MedicoID).HasColumnName("medico_id");
            builder.Property(x => x.UnidadeID).HasColumnName("unidade_id");

            builder.HasOne(x => x.Medico).WithMany(x => x.Unidades).HasForeignKey(x => x.UnidadeID);
            builder.HasOne(x => x.Unidade).WithMany(x => x.Medicos).HasForeignKey(x => x.MedicoID);

        }
    }
}
