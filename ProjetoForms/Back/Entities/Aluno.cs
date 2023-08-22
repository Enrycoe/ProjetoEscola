using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoForms.Back.Entities
{
    public class Aluno : Pessoa
    {
        
        string telefonePessoal;
        string telefoneFixo;
        string telefoneResponsavel;
        string telefoneResponsavel2;
        Turma turma;
        List<Prova> provas;

        int idadeMinima = 13;
        int idadeMaxima = 21;

        public string TelefonePessoal { get => telefonePessoal; set => telefonePessoal = value; }
        public string TelefoneFixo { get => telefoneFixo; set => telefoneFixo = value; }
        public string TelefoneResponsavel { get => telefoneResponsavel; set => telefoneResponsavel = value; }
        public string TelefoneResponsavel2 { get => telefoneResponsavel2; set => telefoneResponsavel2 = value; }
        public int IdadeMinima { get => idadeMinima; set => idadeMinima = value; }
        public int IdadeMaxima { get => idadeMaxima; set => idadeMaxima = value; }
        public List<Prova> Provas { get => provas; set => provas = value; }
        public Turma Turma { get => turma; set => turma = value; }
    }
}
