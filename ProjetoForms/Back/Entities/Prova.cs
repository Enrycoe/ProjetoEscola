using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Prova
    {
        private int id;
        private double nota;
        private Materia materia;
        private string descricao;
        private Media media;
        private double notaMinima = 0;
        private double notaMaxima = 10;
        private Aluno aluno;

        public Prova()
        {
        }

        public Prova(int idProva)
        {
            this.id = idProva;
        }

        public Prova(double nota, string descricao, Materia materia, Aluno aluno)
        {
            this.nota = nota;
            this.descricao = descricao;
            this.materia = materia;
            this.aluno = aluno;
        }

        public Prova(int idProva, double nota, string descricao, Materia materia, Aluno aluno) 
        {
            this.id = idProva;
            this.nota = nota;
            this.descricao = descricao;
            this.materia= materia;
            this.aluno = aluno; 
        }

        public int Id { get => id; set => id = value; }
        public double Nota { get => nota; set => nota = value; }
        public double NotaMinima { get => notaMinima; set => notaMinima = value; }
        public double NotaMaxima { get => notaMaxima; set => notaMaxima = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Aluno Aluno { get => aluno; set => aluno = value; }
        public Materia Materia { get => materia; set => materia = value; }
        public Media Media { get => media; set => media = value; }
    }
}
