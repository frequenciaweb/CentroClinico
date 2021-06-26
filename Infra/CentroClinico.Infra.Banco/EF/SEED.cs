using System.Linq;

namespace CentroClinico.Infra.Banco.EF
{
    public static class SEED
    {
        public static void PopularBanco(EFContext contexto)
        {
            if (contexto.Usuarios.ToList().Count == 0)
            {
                contexto.Usuarios.Add(new Dominio.Entidades.Usuario
                {
                    Ativo = true,
                    Celular = "61999999999",
                    Email = "admin@teste.com",
                    Nome = "Administrador",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Administrador,
                    Senha = "123456"
                });
            }
            contexto.SaveChanges();
        }
    }
}
