using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    internal class Prova
    {
        int id;
        double nota;
        Materia materia;
        string descricao;
        Media media;
        double notaMinima = 0;
        double notaMaxima = 10;
        Aluno aluno;

        public int Id { get => id; set => id = value; }
        public double Nota { get => nota; set => nota = value; }
        public double NotaMinima { get => notaMinima; set => notaMinima = value; }
        public double NotaMaxima { get => notaMaxima; set => notaMaxima = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Aluno Aluno { get => aluno; set => aluno = value; }
        internal Materia Materia { get => materia; set => materia = value; }
        internal Media Media { get => media; set => media = value; }
    }
}
