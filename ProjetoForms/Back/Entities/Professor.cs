using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    internal class Professor : Pessoa
    {
        string telefonePessoal;
        string telefoneFixo;
        List<Materia> materias;
        List<Turma> turmas;

        public string TelefonePessoal { get => telefonePessoal; set => telefonePessoal = value; }
        public string TelefoneFixo { get => telefoneFixo; set => telefoneFixo = value; }
        internal List<Materia> Materias { get => materias; set => materias = value; }
        internal List<Turma> Turmas { get => turmas; set => turmas = value; }
    }
}
