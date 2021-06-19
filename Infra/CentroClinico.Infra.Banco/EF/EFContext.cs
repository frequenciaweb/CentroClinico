using CentroClinico.Dominio.Entidades;
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
                string mySqlConnectionStr = "Server=192.168.0.100;Port=3306;Database=centro_clinico;Uid=root;Pwd=Ab134679";
                optionsBuilder.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


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
