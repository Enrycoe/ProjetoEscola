﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Bimestre
    {
        private int id;
        private string nome;

        public Bimestre()
        {
        }

        public Bimestre(int idBimestre)
        {
            this.id = idBimestre;
        }

        public Bimestre(int idBimestre, string nome)
        {
            this.id = idBimestre;
            this.nome = nome;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
