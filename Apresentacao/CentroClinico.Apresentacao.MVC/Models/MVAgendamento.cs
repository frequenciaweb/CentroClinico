using CentroClinico.Dominio.Enumeradores;
using System;
using System.ComponentModel.DataAnnotations;

namespace CentroClinico.Apresentacao.MVC.Models
{
    public class MVAgendamento
    {
        public EnumTipoConsulta TipoConsulta { get; set; }

        [Required(ErrorMessage = "Informe seu nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe uma Senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe seu número de Celular")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Informe Data de Nascimento")]
        public DateTime Nascimento { get; set; }

        public int EspecialidadeID { get; set; }
    }
}
