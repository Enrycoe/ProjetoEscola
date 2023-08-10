using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    internal class Materia
    {
        int id;
        string nomeMateria;
        string descricao;
        List<Professor> professoresPorMateria;

        public int Id { get => id; set => id = value; }
        public string NomeMateria { get => nomeMateria; set => nomeMateria = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        internal List<Professor> ProfessoresPorMateria { get => professoresPorMateria; }
    }
}
