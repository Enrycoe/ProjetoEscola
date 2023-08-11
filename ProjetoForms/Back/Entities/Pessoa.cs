using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Pessoa
    {
        private int id;
        private string nome;
        private DateTime dataNascimento;
        private int idade;
        Endereco endereco;
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int Idade { get => idade; set => idade = value; }
        internal Endereco Endereco { get => endereco; set => endereco = value; }

        public int CalcularIdade(DateTime dataNascimento)
        {
            if (dataNascimento.Day <= DateTime.Now.Day)
            {
                return DateTime.Now.Year - dataNascimento.Year;
            }
            return DateTime.Now.Year - dataNascimento.Year - 1;
        }
        
    }
}
