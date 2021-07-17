using System;

namespace CentroClinico.Dominio.Entidades
{
    public class Consulta
    {
        public Guid ID { get; set; } = Guid.NewGuid();

        public Guid MedicoID { get; set; }
        public Medico Medico { get; set; }

        public DateTime DataHora { get; set; }

        public Guid UnidadeID { get; set; }
        public Unidade Unidade { get; set; }

        public Guid ClienteID {get; set;}
        public Cliente Cliente { get; set; }

        public Guid EspecialidadeID { get; set; }
        public Especialidade Especialidade { get; set; }

        public bool Particular { get; set; }


    }
}
