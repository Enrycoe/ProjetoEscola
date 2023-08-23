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
        UsuarioModel usuarioModel = new UsuarioModel();

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
                int idUsuario = usuarioModel.GerarERetornarLogin();
                professor.Idade = professor.CalcularIdade(professor.DataNascimento);
                dao.Cadastrar(professor, idUsuario);
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

        internal List<Professor> BuscarPorNome(string nome)
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
