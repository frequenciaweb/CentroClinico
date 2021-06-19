using System;

namespace CentroClinico.Dominio.Entidades
{
    public class Funcionario
    {
        public Guid ID { get; set; }

        public string CPF { get; set; }
        
        public string CEP { get; set; }
        public string NumeroEndereco { get; set; }
        public string Complemento { get; set; }

        public Guid UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
    }
}
