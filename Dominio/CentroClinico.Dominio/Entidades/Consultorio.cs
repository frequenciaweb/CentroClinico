using System;

namespace CentroClinico.Dominio.Entidades
{
    public class Consultorio
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public int Sala { get; set; }
        public int Andar { get; set; }

        public Guid UnidadeID { get; set; }
        public Unidade Unidade { get; set; }
    }
}
