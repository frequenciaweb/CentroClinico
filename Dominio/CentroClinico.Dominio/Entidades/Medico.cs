using System;
using System.Collections.Generic;

namespace CentroClinico.Dominio.Entidades
{
    public class Medico
    {
        public Guid ID { get; set; } = Guid.NewGuid();

        public string CRM { get; set; }
        public string CPF { get; set; }

        public List<MedicoEspecialidade> Especialidades { get; set; }
        public List<MedicoUnidade> Unidades { get; set; }

        public Guid UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
    }
}
