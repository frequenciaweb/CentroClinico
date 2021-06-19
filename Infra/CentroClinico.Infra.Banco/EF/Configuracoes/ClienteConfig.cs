using CentroClinico.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Banco.EF.Configuracoes
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("clientes");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).HasColumnName("cliente_id").ValueGeneratedOnAdd();
            builder.Property(x => x.NumeroCartaoConvenio)
                .HasColumnName("numero_cartao_convenio")
                .HasMaxLength(16);

            builder.Property(x => x.Plano)
                .HasColumnName("plano")
                .HasMaxLength(50);

            builder.Property(x => x.Operadora)
                .HasColumnName("operadora")
                .HasMaxLength(30);
                        

            builder.Property(x => x.UsuarioID)
                .HasColumnName("usaurio_id")
                .IsRequired();

            builder.HasOne(x => x.Usuario);

        }
    }
}
