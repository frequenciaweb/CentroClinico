using System;
using System.Collections.Generic;

namespace CentroClinico.Dominio.Entidades
{
    public class Especialidade
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }

        public List<MedicoEspecialidade> Medicos { get; set; }

    }
}
