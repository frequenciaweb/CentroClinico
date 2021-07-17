using System;

namespace CentroClinico.Dominio.Entidades
{
    public class Cliente
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        
        public string NumeroCartaoConvenio { get; set; }
        public string Operadora { get; set; }
        public string Plano { get; set; }

        public Guid UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

    }
}
