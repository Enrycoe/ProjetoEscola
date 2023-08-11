using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Model
{
    public interface IPessoaModel
    {
        
        void Cadastrar(Pessoa pessoa);

        void Atualizar (Pessoa pessoa, Pessoa pessoaAtualizada);

        DataTable Listar();

        void Deletar(int id);
    }
}
