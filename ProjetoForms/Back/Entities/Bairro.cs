using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    internal class Bairro
    {
        int id;
        string nomeBairro;
        Cidade cidade;

        public int Id { get => id; set => id = value; }
        public string NomeBairro { get => nomeBairro; set => nomeBairro = value; }
        internal Cidade Cidade { get => cidade; set => cidade = value; }
    }
}
