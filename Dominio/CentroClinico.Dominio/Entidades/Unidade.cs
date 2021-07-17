using System;
using System.Collections.Generic;

namespace CentroClinico.Dominio.Entidades
{
    public class Unidade
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; } 
        public string Cidade { get; set; }
                
        public List<Consultorio> Consultorios { get; set; }
        public List<Consulta> Consultas { get; set; }
        public List<MedicoUnidade> Medicos { get; set; }

    }
}
