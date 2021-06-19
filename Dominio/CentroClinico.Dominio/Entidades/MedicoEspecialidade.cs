using System;

namespace CentroClinico.Dominio.Entidades
{
    public class MedicoEspecialidade
    {
        public Guid ID { get; set; }

        public Guid MedicoID { get; set; }
        public Medico Medico { get; set; }

        public Guid EspecialidadeID { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}
