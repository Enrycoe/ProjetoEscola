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
    internal class AlunoModel
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

        public void CadastrarAluno(Aluno aluno)
        {
            try 
            {
                aluno.Id = dao.GerarRA();
                aluno.Idade = CalcularIdade(aluno.DataNascimento);
                dao.CadastrarAluno(aluno);
            }
            catch (Exception)
            {

                throw;
            }
            //string nome = txtNomeCompleto.Text;
            //string NascimentoStr = dtNascimento.Value.ToString("yyyy/MM/dd");
            //DateTime DataDeNascimento = DateTime.Parse(NascimentoStr);
        }

        public int CalcularIdade(DateTime dataNascimento)
        {
            if(dataNascimento.Day <= DateTime.Now.Day)
            {
                return DateTime.Now.Year - dataNascimento.Year;
            }
            return DateTime.Now.Year - dataNascimento.Year - 1;
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

        internal void AtualizarAluno(Aluno aluno, Aluno alunoAntigo)
        {
            try
            {
                aluno.Idade = CalcularIdade(aluno.DataNascimento);
                dao.AtualizarAluno(aluno, alunoAntigo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void DeletarAluno(int id)
        {
            try
            {
                dao.DeleterAluno(id);
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
