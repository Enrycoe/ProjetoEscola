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
                    
                    dao.Cadastrar(aluno);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
           
        }

        

        internal Aluno ReceberAlunoPorId(int id)
        {
            try
            {
                return dao.ReceberAlunoPorId(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Atualizar(Pessoa aluno, Pessoa alunoAtualido)
        {
            if (aluno.GetType() == typeof(Aluno))
            {
                try
                {
                    
                    dao.Atualizar(aluno, alunoAtualido);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
               
        }

        public void Deletar(int id)
        {
            try
            {
                dao.Deletar(id);
            }
            catch (Exception ex)
            {

                throw ex;
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

        internal DataTable BuscarAlunoPorRAETurma(int rA, int idTurma)
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

        internal DataTable BuscarAlunoPorTurma(int idTurma)
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

        internal DataTable PesquisarAluno(string nome, string raStr, int ra, string turma, int idTurma)
        {
            try
            {
                if (!(string.IsNullOrEmpty(nome)) && !(string.IsNullOrEmpty(raStr)) && !(string.IsNullOrEmpty(turma)))
                {

                    return BuscarAluno(nome, ra, idTurma);

                }
                if (!(string.IsNullOrEmpty(nome)) && (string.IsNullOrEmpty(raStr)) && (string.IsNullOrEmpty(turma)))
                {
                    return BuscarAlunoPorNome(nome);
                }
                if (!(string.IsNullOrEmpty(nome)) && !(string.IsNullOrEmpty(raStr)) && (string.IsNullOrEmpty(turma)))
                {

                    return BuscarAlunoPorNomeERA(nome, ra);

                }
                if (!(string.IsNullOrEmpty(nome)) && (string.IsNullOrEmpty(raStr)) && !(string.IsNullOrEmpty(turma)))
                {

                    return BuscarAlunoPorNomeETurma(nome, idTurma);
                }
                if (string.IsNullOrEmpty(nome) && !(string.IsNullOrEmpty(raStr)) && (string.IsNullOrEmpty(turma)))
                {

                    return BuscarAlunoPorRA(ra);
                }

                if (string.IsNullOrEmpty(nome) && !(string.IsNullOrEmpty(raStr)) && !(string.IsNullOrEmpty(turma)))
                {
                    return BuscarAlunoPorRAETurma(ra, idTurma);
                }

                if (string.IsNullOrEmpty(nome) && (string.IsNullOrEmpty(raStr)) && !(string.IsNullOrEmpty(turma)))
                {
                    return BuscarAlunoPorTurma(idTurma);

                }
                return Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
       
    }
}
