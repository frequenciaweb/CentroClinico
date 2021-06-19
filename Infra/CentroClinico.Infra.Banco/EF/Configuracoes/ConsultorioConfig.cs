using CentroClinico.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroClinico.Infra.Banco.EF.Configuracoes
{
    public class ConsultorioConfig : IEntityTypeConfiguration<Consultorio>
    {
        public void Configure(EntityTypeBuilder<Consultorio> builder)
        {
            builder.ToTable("consultorios");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).HasColumnName("consultorio_id");
            builder.Property(x => x.Sala).HasColumnName("sala").IsRequired();
            builder.Property(x => x.Andar).HasColumnName("andar").IsRequired();
            builder.Property(x => x.UnidadeID).HasColumnName("unidade_id");

            builder.HasOne(x => x.Unidade).WithMany(x => x.Consultorios).HasForeignKey(x => x.UnidadeID);

        }
    }
}
