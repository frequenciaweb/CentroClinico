using CentroClinico.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Banco.EF.Configuracoes
{
    public class MedicoConfig : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("medicos");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).HasColumnName("medico_id").ValueGeneratedOnAdd();
            builder.Property(x => x.UsuarioID).HasColumnName("usuario_id");
            builder.Property(x => x.CRM).HasColumnName("crm").IsRequired().HasMaxLength(30);
            builder.Property(x => x.CPF).HasColumnName("cpf").HasMaxLength(11).IsRequired();

            builder.HasOne(x => x.Usuario);
        }
    }
}
