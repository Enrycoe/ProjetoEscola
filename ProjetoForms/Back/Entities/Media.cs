using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Media
    {
        private int id;
        private Materia materia;
        private double valorMedia;
        private Aluno aluno;
        private Bimestre bimestre;
        private List<Prova> provas;
        private double notaMinima = 7;

        public Media()
        {
        }
        public Media(int idMedia)
        {
            this.id = idMedia;
        }

        public Media(double notaMedia, Bimestre bimestre, Materia materia, Aluno aluno)
        {
            this.valorMedia = notaMedia;
            this.bimestre = bimestre;
            this.materia = materia;
            this.aluno = aluno;
        }

        public int Id { get => id; set => id = value; }
        public double ValorMedia { get => valorMedia; set => valorMedia = value; }
        public Aluno Aluno { get => aluno; set => aluno = value; }
        public double NotaMinima { get => notaMinima; set => notaMinima = value; }
        public Materia Materia { get => materia; set => materia = value; }
        public List<Prova> Provas { get => provas; set => provas = value; }
        public Bimestre Bimestre { get => bimestre; set => bimestre = value; }
    }
}
