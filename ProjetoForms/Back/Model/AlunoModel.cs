using ProjetoForms.Back.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoForms.Back.Entities;
using MySql.Data.MySqlClient;

namespace ProjetoForms.Back.Model
{
    public class AlunoModel : IPessoaModel
    {
        AlunoDAO dao = new AlunoDAO(new ConexaoMySQL());

        public List<T> Listar<T>() where T : Pessoa
        {
            try
            {
                return dao.BuscarTodosAlunos() as List<T>;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(Pessoa aluno)
        {

            try
            {
                aluno.Id = GerarRA();

                dao.Cadastrar(aluno);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private int GerarRA()
        {
            string raStr;
            int ra;
            try
            {
                do
                {
                    string anoRa = DateTime.Now.Year.ToString();
                    string raNum = new Random().Next(1000, 9999).ToString();
                    raStr = anoRa + raNum;
                    ra = Convert.ToInt32(raStr);
                } while (dao.VerificarSeRAExiste(ra));
                return ra;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Aluno ReceberAlunoPorId(int id)
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

        public void AtualizarPorId(Pessoa aluno, Pessoa alunoAtualido)
        {

            try
            {
                dao.AtualizarPorId(aluno, alunoAtualido);
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

        internal List<Aluno> BuscarAluno(string nome, int rA, int idTurma)
        {
            try
            {
          
                return dao.BuscarAluno(nome, rA, idTurma);
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Aluno> BuscarAlunoPorNome(string nome)
        {
            try
            {
                return dao.BuscarAlunoPorNome(nome);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Aluno> BuscarAlunoPorNomeERA(string nome, int rA)
        
        {
            try
            {
                return dao.BuscarAlunoPorNomeERA(nome, rA);
            }
            catch (Exception ex) 
            {
                throw ex; 
            }
        }

        public List<Aluno> BuscarAlunoPorNomeETurma(string nome, int idTurma)
        {
            try
            {
                return dao.BuscarAlunoPorNomeETurma(nome, idTurma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Aluno> BuscarAlunoPorRA(int rA) 
        {
            try
            {
                return dao.BuscarAlunoPorRA(rA);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Aluno> BuscarAlunoPorRAETurma(int rA, int idTurma)
        {
            try
            {
                return dao.BuscarAlunoPorRAETurma(rA, idTurma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Aluno> BuscarAlunoPorTurma(int idTurma)
        {
            try
            {
                return dao.BuscarAlunoPorTurma(idTurma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<T> PesquisarAluno<T>(string nome, string raStr, int ra, string turma, int idTurma) where T : Pessoa
        {
            try
            {
                if (!(string.IsNullOrEmpty(nome)) && !(string.IsNullOrEmpty(raStr)) && !(string.IsNullOrEmpty(turma)))
                {

                    return BuscarAluno(nome, ra, idTurma) as List<T>;

                }
                if (!(string.IsNullOrEmpty(nome)) && (string.IsNullOrEmpty(raStr)) && (string.IsNullOrEmpty(turma)))
                {
                    return BuscarAlunoPorNome(nome) as List<T>;
                }
                if (!(string.IsNullOrEmpty(nome)) && !(string.IsNullOrEmpty(raStr)) && (string.IsNullOrEmpty(turma)))
                {

                    return BuscarAlunoPorNomeERA(nome, ra) as List<T>;

                }
                if (!(string.IsNullOrEmpty(nome)) && (string.IsNullOrEmpty(raStr)) && !(string.IsNullOrEmpty(turma)))
                {

                    return BuscarAlunoPorNomeETurma(nome, idTurma) as List<T>;
                }
                if (string.IsNullOrEmpty(nome) && !(string.IsNullOrEmpty(raStr)) && (string.IsNullOrEmpty(turma)))
                {

                    return BuscarAlunoPorRA(ra) as List<T>;
                }

                if (string.IsNullOrEmpty(nome) && !(string.IsNullOrEmpty(raStr)) && !(string.IsNullOrEmpty(turma)))
                {
                    return BuscarAlunoPorRAETurma(ra, idTurma) as List<T>;
                }

                if (string.IsNullOrEmpty(nome) && (string.IsNullOrEmpty(raStr)) && !(string.IsNullOrEmpty(turma)))
                {
                    return BuscarAlunoPorTurma(idTurma) as List<T>;

                }
                return Listar<T>();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}
