using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    internal class Professor : Pessoa
    {
        string estadoCivil;
        List<Materia> materiaPorProfessor;
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        internal List<Materia> MateriaPorProfessor { get => materiaPorProfessor; }
    }
}
