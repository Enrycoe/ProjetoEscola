using ProjetoForms.Back.DAO;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Model
{
    internal class ProfessorModel : IPessoaModel
    {
        ProfessorDAO dao = new ProfessorDAO();

        public void AtualizarPorId(Pessoa pessoa, Pessoa pessoaAtualizada)
        {

            try
            {
                pessoaAtualizada.Idade = pessoaAtualizada.CalcularIdade(pessoaAtualizada.DataNascimento);
                dao.Atualizar(pessoa, pessoaAtualizada);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Cadastrar(Pessoa professor)
        {
            try
            {
                professor.Idade = professor.CalcularIdade(professor.DataNascimento);
                dao.Cadastrar(professor);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DeletarPorId(int id)
        {
            try
            {
                dao.DeletarPorId(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<T> Listar<T>() where T : Pessoa
        {
            try
            {
                 
                return dao.BuscarTodosProfessores() as List<T>;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable BuscarPorNome(string nome)
        {
            return dao.BuscarPorNome(nome);
        }

        internal Professor ReceberProfessorPorId(int id)
        {
            try
            {
                return dao.ReceberProfessorPorId(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
