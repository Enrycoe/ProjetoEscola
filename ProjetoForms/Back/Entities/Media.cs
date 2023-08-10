﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    internal class Media
    {
        int id;
        Materia materia;
        double valorMedia;
        Aluno aluno;
        Bimestre bimestre;
        List<Prova> provas;
        double notaMinima = 7;

        public int Id { get => id; set => id = value; }
        public double ValorMedia { get => valorMedia; set => valorMedia = value; }
        public Aluno Aluno { get => aluno; set => aluno = value; }
        public double NotaMinima { get => notaMinima; set => notaMinima = value; }
        public Materia Materia { get => materia; set => materia = value; }
        public List<Prova> Provas { get => provas; set => provas = value; }
        public Bimestre Bimestre { get => bimestre; set => bimestre = value; }
    }
}
