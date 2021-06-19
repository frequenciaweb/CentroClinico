using System;
using System.Collections.Generic;

namespace CentroClinico.Dominio.Entidades
{
    public class Unidade
    {
        public Guid ID { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; } 
        public string Cidade { get; set; }

        public List<Medico> Medicos { get; set; }
        public List<Consultorio> Consultorios { get; set; }

    }
}
