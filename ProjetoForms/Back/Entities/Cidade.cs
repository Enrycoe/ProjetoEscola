using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    internal class Cidade
    {
        int id;
        string nome;
        Estado estado;
        List<Bairro> bairros;
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Estado Estado { get => estado; set => estado = value; }
        internal List<Bairro> Bairros { get => bairros; set => bairros = value; }
    }
}
