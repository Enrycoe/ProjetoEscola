using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Cidade
    {
        private int id;
        private string nome;
        private Estado estado;

        public Cidade()
        {
            
        }

        public Cidade(int idCidade)
        {
            this.id = idCidade;
        }

        public Cidade(int idCidade, string nome) 
        {
            this.id = idCidade;
            this.nome = nome;
        }

        public Cidade(int idCidade, string nome, Estado estado)
        {
            this.id = idCidade;
            this.nome = nome;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public Estado Estado { get => estado; set => estado = value; }
        
    }
}
