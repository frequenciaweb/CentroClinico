using CentroClinico.Dominio.Enumeradores;
using System;

namespace CentroClinico.Dominio.Entidades
{
    public class Usuario
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }        
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Celular { get; set; }
        public EnumPerfil Perfil { get; set; }        
    }
}
