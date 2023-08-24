using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Materia
    {
        private int id;
        string nomeMateria;
        List<Professor> professoresPorMateria;


        public Materia()
        {
        }
        public Materia(int idMateria)
        {
            this.id = idMateria;
        }

        public Materia(int idMateria, string nome) 
        {
            this.id = idMateria;
            this.nomeMateria = nome;
        }

        public int Id { get => id; set => id = value; }
        public string NomeMateria { get => nomeMateria; set => nomeMateria = value; }
        internal List<Professor> ProfessoresPorMateria { get => professoresPorMateria; }
    }
}
