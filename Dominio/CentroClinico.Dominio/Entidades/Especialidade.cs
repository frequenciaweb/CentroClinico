using System;
using System.Collections.Generic;

namespace CentroClinico.Dominio.Entidades
{
    public class Especialidade
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }

        public List<MedicoEspecialidade> Medicos { get; set; }
        public List<Consulta> Consultas { get; set; }

    }
}
