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
                    Senha = "123456",
                    Nascimento = new System.DateTime(1990,1,1)
                });
            }

            if (contexto.Especialidades.ToList().Count == 0)
            {
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Acupuntura " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Alergia e Imunologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Anestesiologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Angiologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cancerologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cardiologia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Cardiovascular" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia da Mão" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia de Cabeça e Pescoço " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia do Aparelho Digestivo " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Geral " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Pediátrica" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Plástica" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Torácica" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Vascular" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Clínica Médica " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Coloproctologia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Dermatologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Endocrinologia e Metabologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Endoscopia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Gastroenterologia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Genética Médica" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Geriatria" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Ginecologia e Obstetrícia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Hematologia e Hemoterapia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Homeopatia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Infectologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Mastologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina de Família e Comunidade " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina do Trabalho " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina de Tráfego" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Esportiva " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Física e Reabilitação " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Intensiva " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Legal e Perícia Médica" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Nuclear " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Preventiva e Social " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Nefrologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Neurocirurgia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Neurologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Nutrologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Oftalmologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Ortopedia e Traumatologia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Otorrinolaringologia " });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Patologia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Patologia Clínica/Medicina Laboratorial" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Pediatria" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Pneumologia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Psiquiatria" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Radiologia e Diagnóstico por Imagem" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Radioterapia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Reumatologia" });
                contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Urologia" });
            }

            contexto.SaveChanges();
        }
    }
}
