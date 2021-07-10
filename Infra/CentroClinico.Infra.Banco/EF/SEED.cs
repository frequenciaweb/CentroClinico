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


        private static void CadastrarEspecialidades()
        {
            if (Contexto.Especialidades.ToList().Count == 0)
            {
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Acupuntura " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Alergia e Imunologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Anestesiologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Angiologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cancerologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cardiologia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Cardiovascular" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia da Mão" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia de Cabeça e Pescoço " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia do Aparelho Digestivo " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Geral " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Pediátrica" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Plástica" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Torácica" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Cirurgia Vascular" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Clínica Médica " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Coloproctologia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Dermatologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Endocrinologia e Metabologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Endoscopia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Gastroenterologia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Genética Médica" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Geriatria" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Ginecologia e Obstetrícia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Hematologia e Hemoterapia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Homeopatia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Infectologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Mastologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina de Família e Comunidade " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina do Trabalho " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina de Tráfego" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Esportiva " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Física e Reabilitação " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Intensiva " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Legal e Perícia Médica" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Nuclear " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Medicina Preventiva e Social " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Nefrologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Neurocirurgia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Neurologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Nutrologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Oftalmologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Ortopedia e Traumatologia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Otorrinolaringologia " });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Patologia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Patologia Clínica/Medicina Laboratorial" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Pediatria" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Pneumologia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Psiquiatria" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Radiologia e Diagnóstico por Imagem" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Radioterapia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Reumatologia" });
                Contexto.Especialidades.Add(new Dominio.Entidades.Especialidade { Nome = "Urologia" });
            }
        }

        private static void CadastrarMedicos()
        {
            if (Contexto.Medicos.ToList().Count() == 0)

                for (int i = 0; i < 500; i++)
                {
                    Contexto.Medicos.Add(new Dominio.Entidades.Medico
                    {
                        CPF = "11111111111",
                        CRM = "1234",
                        Usuario = new Dominio.Entidades.Usuario
                        {
                            Ativo = false,
                            Celular = "6199998888",
                            Email = "medico@teste.com",
                            Nascimento = new System.DateTime(1958, 1, 1),
                            Nome = Nomes[Random.Next(0, Nomes.Count - 1)] + " " + Sobrenomes[Random.Next(0,Sobrenomes.Count - 1)],
                            Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                            Senha = "123456"
                        }
                    });
                }
             
               

            Contexto.Medicos.Add(new Dominio.Entidades.Medico
            {
                CPF = "11111111111",
                CRM = "1234",
                Usuario = new Dominio.Entidades.Usuario
                {
                    Ativo = false,
                    Celular = "6199998888",
                    Email = "medico@teste.com",
                    Nascimento = new System.DateTime(1958, 1, 1),
                    Nome = "CARLOS ANDRE",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                    Senha = "123456"
                }
            });

            Contexto.Medicos.Add(new Dominio.Entidades.Medico
            {
                CPF = "11111111111",
                CRM = "1234",
                Usuario = new Dominio.Entidades.Usuario
                {
                    Ativo = false,
                    Celular = "6199998888",
                    Email = "medico@teste.com",
                    Nascimento = new System.DateTime(1958, 1, 1),
                    Nome = "MARIA TERESA",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                    Senha = "123456"
                }
            });

            Contexto.Medicos.Add(new Dominio.Entidades.Medico
            {
                CPF = "11111111111",
                CRM = "1234",
                Usuario = new Dominio.Entidades.Usuario
                {
                    Ativo = false,
                    Celular = "6199998888",
                    Email = "medico@teste.com",
                    Nascimento = new System.DateTime(1958, 1, 1),
                    Nome = "FERNANDA LIMA",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                    Senha = "123456"
                }
            });

            Contexto.Medicos.Add(new Dominio.Entidades.Medico
            {
                CPF = "11111111111",
                CRM = "1234",
                Usuario = new Dominio.Entidades.Usuario
                {
                    Ativo = false,
                    Celular = "6199998888",
                    Email = "medico@teste.com",
                    Nascimento = new System.DateTime(1958, 1, 1),
                    Nome = "PEDOR HENRIQUE",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                    Senha = "123456"
                }
            });

            Contexto.Medicos.Add(new Dominio.Entidades.Medico
            {
                CPF = "11111111111",
                CRM = "1234",
                Usuario = new Dominio.Entidades.Usuario
                {
                    Ativo = false,
                    Celular = "6199998888",
                    Email = "medico@teste.com",
                    Nascimento = new System.DateTime(1958, 1, 1),
                    Nome = "MARIO HENRIQUE",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                    Senha = "123456"
                }
            });

            Contexto.Medicos.Add(new Dominio.Entidades.Medico
            {
                CPF = "11111111111",
                CRM = "1234",
                Usuario = new Dominio.Entidades.Usuario
                {
                    Ativo = false,
                    Celular = "6199998888",
                    Email = "medico@teste.com",
                    Nascimento = new System.DateTime(1958, 1, 1),
                    Nome = "PAULO JOSE",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                    Senha = "123456"
                }
            });

            Contexto.Medicos.Add(new Dominio.Entidades.Medico
            {
                CPF = "11111111111",
                CRM = "1234",
                Usuario = new Dominio.Entidades.Usuario
                {
                    Ativo = false,
                    Celular = "6199998888",
                    Email = "medico@teste.com",
                    Nascimento = new System.DateTime(1958, 1, 1),
                    Nome = "ANDRE PAULO",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                    Senha = "123456"
                }
            });

            Contexto.Medicos.Add(new Dominio.Entidades.Medico
            {
                CPF = "11111111111",
                CRM = "1234",
                Usuario = new Dominio.Entidades.Usuario
                {
                    Ativo = false,
                    Celular = "6199998888",
                    Email = "medico@teste.com",
                    Nascimento = new System.DateTime(1958, 1, 1),
                    Nome = "JOSIANE CARDOSO",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                    Senha = "123456"
                }
            });

            Contexto.Medicos.Add(new Dominio.Entidades.Medico
            {
                CPF = "11111111111",
                CRM = "1234",
                Usuario = new Dominio.Entidades.Usuario
                {
                    Ativo = false,
                    Celular = "6199998888",
                    Email = "medico@teste.com",
                    Nascimento = new System.DateTime(1958, 1, 1),
                    Nome = "PEDRO PAULO",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                    Senha = "123456"
                }
            });

            Contexto.Medicos.Add(new Dominio.Entidades.Medico
            {
                CPF = "11111111111",
                CRM = "1234",
                Usuario = new Dominio.Entidades.Usuario
                {
                    Ativo = false,
                    Celular = "6199998888",
                    Email = "medico@teste.com",
                    Nascimento = new System.DateTime(1958, 1, 1),
                    Nome = "HENIRQUE SOARES",
                    Perfil = Dominio.Enumeradores.EnumPerfil.Medico,
                    Senha = "123456"
                }
            });
        }

        private static void CadastrarUsuarios()
        {
            if (Contexto.Usuarios.ToList().Count == 0)
            {
                Contexto.Usuarios.Add(new Dominio.Entidades.Usuario
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

            VincularMedicoUnidade();
            VincularMedicoEspecialidade();

            Contexto.SaveChanges();
        }

        private static void VincularMedicoEspecialidade()
        {
            if (Contexto.MedicoEspecialidades.ToList().Count() == 0)
            {
                var medicos = Contexto.Medicos.ToList();
                var especialidades = Contexto.Especialidades.ToList();

                medicos.ForEach(medico =>
                {
                    Contexto.MedicoEspecialidades.Add(new Dominio.Entidades.MedicoEspecialidade
                    {
                        EspecialidadeID = especialidades[Random.Next(0, especialidades.Count - 1)].ID,
                        MedicoID = medico.ID

                    });
                });
            }
        }

        private static void VincularMedicoUnidade()
        {
            if (Contexto.MedicoUnidades.ToList().Count == 0)
            {
                var medicos = Contexto.Medicos.ToList();
                var unidades = Contexto.Unidades.ToList();

                medicos.ForEach(medico =>
                {
                    Contexto.MedicoUnidades.Add(new Dominio.Entidades.MedicoUnidade { MedicoID = medico.ID, UnidadeID = unidades[Random.Next(0, unidades.Count - 1)].ID });
                });
            }
        }

        private static void CadastrarUnidades()
        {
            if (Contexto.Unidades.ToList().Count == 0)
            {
                Contexto.Unidades.Add(new Dominio.Entidades.Unidade
                {
                    CEP = "12345678",
                    Cidade = "BRASILIA",
                    Complemento = "",
                    Numero = "14",
                });

                Contexto.Unidades.Add(new Dominio.Entidades.Unidade
                {
                    CEP = "12345678",
                    Cidade = "GOIANIA",
                    Complemento = "",
                    Numero = "14",
                });

                Contexto.Unidades.Add(new Dominio.Entidades.Unidade
                {
                    CEP = "12345678",
                    Cidade = "SÃO PAULO",
                    Complemento = "",
                    Numero = "14",
                });

                Contexto.Unidades.Add(new Dominio.Entidades.Unidade
                {
                    CEP = "12345678",
                    Cidade = "RIO DE JANEIRO",
                    Complemento = "",
                    Numero = "14",
                });
            }
        }
    }
}
