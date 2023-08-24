using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Bairro
    {
        int id;
        string nomeBairro;
        Cidade cidade;

        public Bairro()
        {
            
        }

        public Bairro(string nomeBairro, Cidade cidade)
        {
            this.nomeBairro = nomeBairro;
            this.cidade = cidade;
        }

        public Bairro(int id, string nomeBairro, Cidade cidade)
        {
            this.id = id;
            this.nomeBairro = nomeBairro;
            this.cidade = cidade;
        }

        public int Id { get => id; set => id = value; }
        public string NomeBairro { get => nomeBairro; set => nomeBairro = value; }
        internal Cidade Cidade { get => cidade; set => cidade = value; }
    }
}
