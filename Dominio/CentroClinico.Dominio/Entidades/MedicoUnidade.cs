using System;

namespace CentroClinico.Dominio.Entidades
{
    public class MedicoUnidade
    {
        public Guid ID { get; set; }

        public Guid MedicoID { get; set; }
        public Medico Medico { get; set; } 

        public Guid UnidadeID { get; set; }
        public Unidade Unidade { get; set; }
    }
}
