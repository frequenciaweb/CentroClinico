using CentroClinico.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Banco.EF.Configuracoes
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).HasColumnName("usuario_id").ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(60).IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Senha).HasColumnName("senha").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Celular).HasColumnName("celular").HasMaxLength(12).IsRequired();
            builder.Property(x => x.Perfil).HasColumnName("perfil").IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();

        }
    }
}
