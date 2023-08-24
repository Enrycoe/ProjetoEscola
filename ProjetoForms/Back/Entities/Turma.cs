using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Turma
    {
        int id;
        string nome;

        public Turma()
        {
        }

        public Turma(int idTurma)
        {
            this.id = idTurma;
        }

        public Turma(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}
