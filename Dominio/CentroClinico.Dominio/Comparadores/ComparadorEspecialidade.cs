using CentroClinico.Dominio.Entidades;
using System.Collections.Generic;

namespace CentroClinico.Dominio.Comparadores
{
    public class ComparadorEspecialidade : IEqualityComparer<MedicoEspecialidade>
    {
        public bool Equals(MedicoEspecialidade a, MedicoEspecialidade b)
        {
            if (a.Especialidade.Nome == b.Especialidade.Nome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public int GetHashCode(MedicoEspecialidade codeh)
        {
            return 0;
        }
    }

}
