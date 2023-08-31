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
        private Endereco endereco;
        private string telefonePessoal;
        private string telefoneFixo;
        public Pessoa()
        {
            
        }

        public Pessoa(int id)
        {
            this.id = id;
        }

        public Pessoa(string nome, DateTime dataNascimento, int idade, Endereco endereco, string telefoneFixo, string telefonePessoal)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.idade = idade;
            this.endereco = endereco;
            this.telefoneFixo = telefoneFixo;
            this.telefonePessoal = telefonePessoal;
        }

        public Pessoa(int id, string nome, DateTime dataNascimento, int idade, Endereco endereco, string telefoneFixo, string telefonePessoal)
        {
            this.id = id;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.idade = idade;
            this.endereco = endereco;
            this.TelefoneFixo = telefoneFixo;
            this.TelefonePessoal = telefonePessoal;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int Idade { get => idade; set => idade = value; }
        public string TelefonePessoal { get => telefonePessoal; set => telefonePessoal = value; }
        public string TelefoneFixo { get => telefoneFixo; set => telefoneFixo = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }

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
