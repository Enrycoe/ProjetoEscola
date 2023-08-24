using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Estado
    {
        int id;
        string nome;
        string sigla;
        List<Cidade> cidades;

        public Estado()
        {
            
        }
        public Estado(int idEstado, string nome, string sigla)
        {
            this.id = idEstado;
            this.nome = nome;
            this.sigla = sigla;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public List<Cidade> Cidades { get => cidades; set => cidades = value; }
    }
}
