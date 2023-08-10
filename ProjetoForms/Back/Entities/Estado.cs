using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    internal class Estado
    {
        int id;
        string nome;
        string sigla;
        List<Cidade> cidades;
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        internal List<Cidade> Cidades { get => cidades; set => cidades = value; }
    }
}
