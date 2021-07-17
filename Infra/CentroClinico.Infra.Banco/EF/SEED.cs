using CentroClinico.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CentroClinico.Infra.Banco.EF
{
    public static class SEED
    {
        private static EFContext Contexto { get; set; }
        private static Random Random { get; set; } = new Random();
        private static List<string> Sobrenomes { get; set; } = new List<string> { "ALVEZ", "CARDOSO", "SILVA", "PEREIRA", "CHAVES" };
        private static List<string> Nomes { get; set; } = new List<string> {"Alice",
"Miguel ",
"Sophia ",
"Arthur ",
"Helena ",
"Bernardo ",
"Valentina",
"Heitor ",
"Laura",
"Davi ",
"Isabella ",
"Lorenzo",
"Manuela",
"Théo ",
"Júlia",
"Pedro",
"Heloísa",
"Gabriel",
"Luiza",
"Enzo ",
"Maria",
"Luiza",
"Matheus",
"Lorena ",
"Lucas",
"Lívia",
"Benjamin ",
"Giovanna ",
"Nicolas",
"Maria",
"Eduarda	",
"Guilherme",
"Beatriz",
"Rafael ",
"Maria",
"Clara	",
"Joaquim",
"Cecília	",
"Samuel ",
"Eloá ",
"Enzo ",
"Gabriel",
"Lara ",
"João ",
"Miguel ",
"Maria",
"Júlia	",
"Henrique ",
"Isadora",
"Gustavo",
"Mariana",
"Murilo ",
"Emanuelly",
"Pedro Henrique ",
"Ana Júlia",
"Pietro ",
"Ana Luiza",
"Lucca",
"Ana Clara",
"Felipe ",
"Melissa",
"João Pedro ",
"Yasmin ",
"Isaac",
"Maria",
"Alice	",
"Benício",
"Isabelly ",
"Daniel ",
"Lavínia",
"Anthony",
"Esther	",
"Leonardo ",
"Sarah",
"Davi ",
"Lucca",
"Elisa	",
"Bryan",
"Antonella",
"Eduardo",
"Rafaela	",
"João ",
"Lucas",
"Maria",
"Cecília	",
"Victor ",
"Liz",
"João ",
"Marina	",
"Cauã ",
"Nicole ",
"Antônio",
"Maitê	",
"Vicente",
"Isis	",
"Caleb",
"Alícia ",
"Gael ",
"Luna	",
"Bento",
"Rebeca ",
"Caio ",
"Agatha " };

        private static List<Unidade> Unidades { get; set; } = new List<Unidade>();
        private static List<Especialidade> Especialidades { get; set; } = new List<Especialidade>();

        private static void CadastrarEspecialidades()
        {
            if (Contexto.Especialidades.ToList().Count == 0)
            {
                Especialidades.Add(new Especialidade { Nome = "Acupuntura " });
                Especialidades.Add(new Especialidade { Nome = "Alergia e Imunologia " });
                Especialidades.Add(new Especialidade { Nome = "Anestesiologia " });
                Especialidades.Add(new Especialidade { Nome = "Angiologia " });
                Especialidades.Add(new Especialidade { Nome = "Cancerologia " });
                Especialidades.Add(new Especialidade { Nome = "Cardiologia" });
                Especialidades.Add(new Especialidade { Nome = "Cirurgia Cardiovascular" });
                Especialidades.Add(new Especialidade { Nome = "Cirurgia da Mão" });
                Especialidades.Add(new Especialidade { Nome = "Cirurgia de Cabeça e Pescoço " });
                Especialidades.Add(new Especialidade { Nome = "Cirurgia do Aparelho Digestivo " });
                Especialidades.Add(new Especialidade { Nome = "Cirurgia Geral " });
                Especialidades.Add(new Especialidade { Nome = "Cirurgia Pediátrica" });
                Especialidades.Add(new Especialidade { Nome = "Cirurgia Plástica" });
                Especialidades.Add(new Especialidade { Nome = "Cirurgia Torácica" });
                Especialidades.Add(new Especialidade { Nome = "Cirurgia Vascular" });
                Especialidades.Add(new Especialidade { Nome = "Clínica Médica " });
                Especialidades.Add(new Especialidade { Nome = "Coloproctologia" });
                Especialidades.Add(new Especialidade { Nome = "Dermatologia " });
                Especialidades.Add(new Especialidade { Nome = "Endocrinologia e Metabologia " });
                Especialidades.Add(new Especialidade { Nome = "Endoscopia " });
                Especialidades.Add(new Especialidade { Nome = "Gastroenterologia" });
                Especialidades.Add(new Especialidade { Nome = "Genética Médica" });
                Especialidades.Add(new Especialidade { Nome = "Geriatria" });
                Especialidades.Add(new Especialidade { Nome = "Ginecologia e Obstetrícia" });
                Especialidades.Add(new Especialidade { Nome = "Hematologia e Hemoterapia" });
                Especialidades.Add(new Especialidade { Nome = "Homeopatia " });
                Especialidades.Add(new Especialidade { Nome = "Infectologia " });
                Especialidades.Add(new Especialidade { Nome = "Mastologia " });
                Especialidades.Add(new Especialidade { Nome = "Medicina de Família e Comunidade " });
                Especialidades.Add(new Especialidade { Nome = "Medicina do Trabalho " });
                Especialidades.Add(new Especialidade { Nome = "Medicina de Tráfego" });
                Especialidades.Add(new Especialidade { Nome = "Medicina Esportiva " });
                Especialidades.Add(new Especialidade { Nome = "Medicina Física e Reabilitação " });
                Especialidades.Add(new Especialidade { Nome = "Medicina Intensiva " });
                Especialidades.Add(new Especialidade { Nome = "Medicina Legal e Perícia Médica" });
                Especialidades.Add(new Especialidade { Nome = "Medicina Nuclear " });
                Especialidades.Add(new Especialidade { Nome = "Medicina Preventiva e Social " });
                Especialidades.Add(new Especialidade { Nome = "Nefrologia " });
                Especialidades.Add(new Especialidade { Nome = "Neurocirurgia" });
                Especialidades.Add(new Especialidade { Nome = "Neurologia " });
                Especialidades.Add(new Especialidade { Nome = "Nutrologia " });
                Especialidades.Add(new Especialidade { Nome = "Oftalmologia " });
                Especialidades.Add(new Especialidade { Nome = "Ortopedia e Traumatologia" });
                Especialidades.Add(new Especialidade { Nome = "Otorrinolaringologia " });
                Especialidades.Add(new Especialidade { Nome = "Patologia" });
                Especialidades.Add(new Especialidade { Nome = "Patologia Clínica/Medicina Laboratorial" });
                Especialidades.Add(new Especialidade { Nome = "Pediatria" });
                Especialidades.Add(new Especialidade { Nome = "Pneumologia" });
                Especialidades.Add(new Especialidade { Nome = "Psiquiatria" });
                Especialidades.Add(new Especialidade { Nome = "Radiologia e Diagnóstico por Imagem" });
                Especialidades.Add(new Especialidade { Nome = "Radioterapia" });
                Especialidades.Add(new Especialidade { Nome = "Reumatologia" });
                Especialidades.Add(new Especialidade { Nome = "Urologia" });

                Contexto.Especialidades.AddRange(Especialidades);
            }
        }

        private static void CadastrarMedicos()
        {
            if (Contexto.Medicos.ToList().Count() == 0)
            {

                for (int i = 0; i < 500; i++)
                {
                    Contexto.Medicos.Add(new Medico
                    {
                        CPF = "11111111111",
                        CRM = Random.Next(1111, 9999).ToString(),
                        Unidades = new List<MedicoUnidade> {
                            new MedicoUnidade { UnidadeID = Unidades[Random.Next(0, Unidades.Count - 1)].ID }
                        },
                        Especialidades = new List<MedicoEspecialidade>
                        {
                          new  MedicoEspecialidade { EspecialidadeID = Especialidades[Random.Next(0, Especialidades.Count - 1)].ID }
                        },
                        Usuario = new Usuario
                        {
                            Ativo = true,
                            Celular = "6199998888",
                            Email = $"medico{i + 1}@teste.com",
                            Nascimento = new DateTime(1958, 1, 1),
                            Nome = Nomes[Random.Next(0, Nomes.Count - 1)] + " " + Sobrenomes[Random.Next(0, Sobrenomes.Count - 1)],
                            Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                            Senha = "123456"
                        }
                    });
                }
            }
        }

        private static void CadastrarUsuarios()
        {
            if (Contexto.Usuarios.ToList().Count == 0)
            {
                Contexto.Usuarios.Add(new Usuario
                {
                    Ativo = true,
                    Celular = "61999999999",
                    Email = "admin@teste.com",
                    Nome = "Administrador",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Administrador,
                    Senha = "123456",
                    Nascimento = new System.DateTime(1990, 1, 1)
                });
            }
        }

        public static void PopularBanco(EFContext contexto)
        {
            Contexto = contexto;

            CadastrarUsuarios();
            CadastrarEspecialidades();
            CadastrarUnidades();
            CadastrarMedicos();

            Contexto.SaveChanges();
        }

        private static void CadastrarUnidades()
        {

            if (Contexto.Unidades.ToList().Count == 0)
            {
                Unidades.Add(new Unidade
                {
                    CEP = "12345678",
                    Cidade = "BRASILIA",
                    Complemento = "",
                    Numero = "14",
                });

                Unidades.Add(new Unidade
                {
                    CEP = "12345678",
                    Cidade = "GOIANIA",
                    Complemento = "",
                    Numero = "14",
                });

                Unidades.Add(new Unidade
                {
                    CEP = "12345678",
                    Cidade = "SÃO PAULO",
                    Complemento = "",
                    Numero = "14",
                });

                Unidades.Add(new Unidade
                {
                    CEP = "12345678",
                    Cidade = "RIO DE JANEIRO",
                    Complemento = "",
                    Numero = "14",
                });
                Contexto.Unidades.AddRange(Unidades);
            }
        }
    }
}
