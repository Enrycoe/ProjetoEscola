using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Endereco
    {
        private int id;
        private string nomeRua;
        private int numCasa;
        private Bairro bairro;

        public Endereco()
        {            
        }

        public Endereco(int numCasa, string nomeRua, Bairro bairro)
        {
            this.numCasa = numCasa;
            this.nomeRua = nomeRua;
            this.bairro = bairro;
        }

        public Endereco(int id, int numCasa, string nomeRua, Bairro bairro)
        {
            this.numCasa = numCasa;
            this.nomeRua = nomeRua;
            this.bairro = bairro;
        }

        public int Id { get => id; set => id = value; }
        public string NomeRua { get => nomeRua; set => nomeRua = value; }
        public int NumCasa { get => numCasa; set => numCasa = value; }
        public Bairro Bairro { get => bairro; set => bairro = value; }
    }
}
