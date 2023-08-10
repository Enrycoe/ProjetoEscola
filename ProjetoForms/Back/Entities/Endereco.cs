using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Endereco
    {
        int id;
        string nomeRua;
        int numCasa;
        Bairro bairro;

        public int Id { get => id; set => id = value; }
        public string NomeRua { get => nomeRua; set => nomeRua = value; }
        public int NumCasa { get => numCasa; set => numCasa = value; }
        internal Bairro Bairro { get => bairro; set => bairro = value; }
    }
}
