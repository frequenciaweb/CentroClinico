using CentroClinico.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Banco.EF.Configuracoes
{
    public class MedicoEspecialidadeConfig : IEntityTypeConfiguration<MedicoEspecialidade>
    {
        public void Configure(EntityTypeBuilder<MedicoEspecialidade> builder)
        {
            builder.ToTable("medico_especialidade");
            builder.HasKey(x => new { x.EspecialidadeID, x.MedicoID });

            builder.Property(x => x.MedicoID).HasColumnName("medico_id");                        
            builder.Property(x => x.EspecialidadeID).HasColumnName("especialidade_id");

            builder.HasOne(x => x.Medico).WithMany(x => x.Especialidades).HasForeignKey(x => x.EspecialidadeID);
            builder.HasOne(x => x.Especialidade).WithMany(x => x.Medicos).HasForeignKey(x => x.MedicoID);

        }
    }
}
