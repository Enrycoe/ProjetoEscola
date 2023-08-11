using ProjetoForms.Back.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoForms.Back.Entities;

namespace ProjetoForms.Back.Model
{
    internal class AlunoModel : IPessoaModel
    {
        AlunoDAO dao = new AlunoDAO();

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Listar();
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(Pessoa aluno)
        {
            if(aluno.GetType() == typeof(Aluno))
            {
                try
                {
                    aluno.Id = dao.GerarRA();
                    aluno.Idade = aluno.CalcularIdade(aluno.DataNascimento);
                    dao.Cadastrar(aluno);
                }
                catch (Exception)
                {

                    throw;
                }
            }
           
        }

        

        internal Aluno ReceberAluno(int id)
        {
            try
            {
                return dao.ReceberAluno(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Atualizar(Pessoa aluno, Pessoa alunoAtualido)
        {
            if (aluno.GetType() == typeof(Aluno))
            {
                try
                {
                    alunoAtualido.Idade = alunoAtualido.CalcularIdade(alunoAtualido.DataNascimento);
                    dao.Atualizar(alunoAtualido, aluno);
                }
                catch (Exception)
                {

                    throw;
                }
            }
               
        }

        public void Deletar(int id)
        {
            try
            {
                dao.Deleter(id);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        internal DataTable BuscarAluno(string nome, int rA, int idTurma)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.BuscarAluno(nome, rA, idTurma);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable BuscarAlunoPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.BuscarAlunoPorNome(nome);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable BuscarAlunoPorNomeERA(string nome, int rA)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.BuscarAlunoPorNomeERA(nome, rA);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable BuscarAlunoPorNomeETurma(string nome, int idTurma)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.BuscarAlunoPorNomeETurma(nome, idTurma);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable BuscarAlunoPorRA(int rA)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.BuscarAlunoPorRA(rA);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal object BuscarAlunoPorRAETurma(int rA, int idTurma)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.BuscarAlunoPorRAETurma(rA, idTurma);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal object BuscarAlunoPorTurma(int idTurma)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.BuscarAlunoPorTurma(idTurma);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
