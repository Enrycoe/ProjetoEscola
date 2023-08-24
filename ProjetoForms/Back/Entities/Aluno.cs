using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoForms.Back.Entities
{
    public class Aluno : Pessoa
    {
        
        private string telefoneResponsavel;
        private string telefoneResponsavel2;
        Turma turma;
        List<Prova> provas;
        public Aluno() 
        {          
        }

        public Aluno(int id, string nome, DateTime dataNascimento, int idade, Endereco endereco, string telefonePessoal, string telefoneFixo, string telefoneResponsavel, string telefoneResponsavel2, Turma turma) : base(id, nome, dataNascimento, idade, endereco, telefoneFixo, telefonePessoal)
        {

            this.telefoneResponsavel = telefoneResponsavel;
            this.telefoneResponsavel2 = telefoneResponsavel2;
            this.turma = turma;

        }
        public Aluno( string nome, DateTime dataNascimento, int idade, Endereco endereco, string telefonePessoal, string telefoneFixo, string telefoneResponsavel, string telefoneResponsavel2, Turma turma) : base( nome, dataNascimento, idade, endereco, telefoneFixo, telefonePessoal)
        {

            this.telefoneResponsavel = telefoneResponsavel;
            this.telefoneResponsavel2 = telefoneResponsavel2;
            this.turma = turma;

        }

        public Aluno(int id) : base (id)
        {
            
        }

        int idadeMinima = 13;
        int idadeMaxima = 21;

        
        public string TelefoneResponsavel { get => telefoneResponsavel; set => telefoneResponsavel = value; }
        public string TelefoneResponsavel2 { get => telefoneResponsavel2; set => telefoneResponsavel2 = value; }
        public int IdadeMinima { get => idadeMinima; set => idadeMinima = value; }
        public int IdadeMaxima { get => idadeMaxima; set => idadeMaxima = value; }
        public List<Prova> Provas { get => provas; set => provas = value; }
        public Turma Turma { get => turma; set => turma = value; }
    }
}
