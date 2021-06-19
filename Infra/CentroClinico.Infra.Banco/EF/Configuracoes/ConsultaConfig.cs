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
    public class ConsultaConfig : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("consultas");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).HasColumnName("consulta_id").ValueGeneratedOnAdd();
            builder.Property(x => x.MedicoID).HasColumnName("medico_id");
            builder.Property(x => x.DataHora).HasColumnName("data_hora").IsRequired();
            builder.Property(x => x.UnidadeID).HasColumnName("unidade_id");
            builder.Property(x => x.ClienteID).HasColumnName("cliente_id");

            builder.HasOne(x => x.Unidade).WithMany(x => x.Consultas).HasForeignKey(x => x.UnidadeID);


        }
    }
}
