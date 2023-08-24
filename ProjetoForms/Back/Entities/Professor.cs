using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Professor : Pessoa
    {
       
        private List<Materia> materias;
        private List<Turma> turmas;

        private int idadeMinima = 21;
        private int idadeMaxima = 100;

        public Professor()
        {
            
        }
        public Professor(int id, string nome, DateTime dataNascimento, int idade, Endereco endereco, string telefonePessoal, string telefoneFixo, List<Materia> materias, List<Turma> turmas) : base(id, nome, dataNascimento, idade, endereco, telefoneFixo, telefonePessoal)
        {
            this.turmas = turmas;
            this.materias = materias;
        }
        public Professor( string nome, DateTime dataNascimento, int idade, Endereco endereco, string telefonePessoal, string telefoneFixo, List<Materia> materias, List<Turma> turmas) : base( nome, dataNascimento, idade, endereco, telefoneFixo, telefonePessoal)
        {
            this.turmas = turmas;
            this.materias = materias;
        }
        public int IdadeMinima { get => idadeMinima; set => idadeMinima = value; }
        public int IdadeMaxima { get => idadeMaxima; set => idadeMaxima = value; }
        public List<Materia> Materias { get => materias; set => materias = value; }
        public List<Turma> Turmas { get => turmas; set => turmas = value; }
    }
}
