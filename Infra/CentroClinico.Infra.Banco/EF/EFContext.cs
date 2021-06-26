using CentroClinico.Dominio.Entidades;
using CentroClinico.Infra.Banco.EF.Configuracoes;
using Microsoft.EntityFrameworkCore;

namespace CentroClinico.Infra.Banco.EF
{
    public class EFContext : DbContext
    {
        public EFContext() { }
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string mySqlConnectionStr = "Server=banco_mysql;Port=3306;Database=centro_clinico;Uid=root;Pwd=A134679";
                optionsBuilder.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.ApplyConfiguration(new ConsultaConfig());
            modelBuilder.ApplyConfiguration(new ConsultorioConfig());
            modelBuilder.ApplyConfiguration(new EspecialidadeConfig());
            modelBuilder.ApplyConfiguration(new FuncionarioConfig());
            modelBuilder.ApplyConfiguration(new MedicoConfig());
            modelBuilder.ApplyConfiguration(new MedicoEspecialidadeConfig());
            modelBuilder.ApplyConfiguration(new UnidadeConfig());            
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new MedicoUnidadeConfig());
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Consultorio> Consultorios { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<MedicoEspecialidade> MedicoEspecialidades { get; set; }
        public DbSet<MedicoUnidade> MedicoUnidades { get; set; }
        public DbSet<Unidade> Unidades { get; set; }        

    }
}
