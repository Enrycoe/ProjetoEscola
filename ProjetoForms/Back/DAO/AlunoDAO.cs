using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;

namespace ProjetoForms.Back.DAO
{
    public class AlunoDAO
    {

        private BairroDAO bairroDAO;
        private EnderecoDAO enderecoDAO;
        private ProvaDAO provaDAO;
        private MediaDAO mediaDAO;
        private IDataBase dataBase;
        private TurmaDAO turmaDAO;
        public AlunoDAO(IDataBase dataBase)
        {
            bairroDAO = new BairroDAO(dataBase);
            enderecoDAO = new EnderecoDAO(dataBase);
            provaDAO = new ProvaDAO(dataBase);
            turmaDAO = new TurmaDAO(dataBase);
            mediaDAO = new MediaDAO(dataBase);
            this.dataBase = dataBase;
        }

        public List<Aluno> BuscarTodosAlunos()
        {
            try
            {

                string querry = "SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID";
                
                List<Dictionary<string, object>> resposta = dataBase.ExecuteReader(querry);

                return ListarAlunos(resposta);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Aluno> ListarAlunos(List<Dictionary<string, object>> resposta)
        {
            try
            {
                List<Aluno> alunos = new List<Aluno>();

                foreach (Dictionary<string, object> linha in resposta)
                {
                    int ra = Convert.ToInt32(linha["RA"]);
                    DateTime dataNascimento = Convert.ToDateTime(linha["Data_de_Nascimento"]);
                    int idade = Convert.ToInt32(linha["Idade"]);
                    string nome = linha["Nome"].ToString();
                    int idTurma = Convert.ToInt32(linha["fk_Turma_ID"]);
                    Turma turma = turmaDAO.ReceberTurmaPorId(idTurma);
                    string telefonePessoal = linha["Telefone_Pessoal"].ToString();
                    string telefoneFixo = linha["Telefone_Fixo"].ToString();
                    string telefoneResponsavel = linha["Telefone_Responsavel"].ToString();
                    string telefoneResponsavel2 = linha["Telefone_Responsavel_2"].ToString();
                    int enderecoId = Convert.ToInt32(linha["fk_endereco_id"]);
                    Endereco endereco = enderecoDAO.ReceberEnderecoPorPessoa(enderecoId);

                    Aluno aluno = new Aluno(ra, nome, dataNascimento, idade, endereco, telefonePessoal, telefoneFixo, telefoneResponsavel, telefoneResponsavel2, turma);
                    alunos.Add(aluno);
                }
                return alunos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Pessoa pessoa)
        {
            Aluno aluno = pessoa as Aluno;
            try
            {
                bool bairroExiste = bairroDAO.VerificarSeBairroExiste(aluno.Endereco.Bairro);
                if (bairroExiste)
                {
                    aluno.Endereco.Bairro.Id = bairroDAO.ReceberIdBairro(aluno.Endereco.Bairro);
                    enderecoDAO.CadastrarEndereco(aluno.Endereco);
                    aluno.Endereco.Id = enderecoDAO.ReceberIDUltimoEndereco();
                }
                else
                {
                    bairroDAO.CadastrarBairro(aluno.Endereco.Bairro);
                    aluno.Endereco.Bairro.Id = bairroDAO.ReceberIdUltimoBairro();
                    enderecoDAO.CadastrarEndereco(aluno.Endereco);
                    aluno.Endereco.Id = enderecoDAO.ReceberIDUltimoEndereco();
                }
                dataBase.AbrirConexao();
                string querry = $"INSERT INTO aluno(Data_de_Nascimento, RA, Idade, Nome, fk_Turma_ID, fk_Endereco_ID, Telefone_Pessoal, Telefone_Fixo, Telefone_Responsavel, Telefone_Responsavel_2) " +
                       $"VALUES(@dataNascimento, @ra, @idade, @nome, @turmaId, @enderecoId, @telefonePessoal, @telefoneFixo, @telefoneResponsavel, @telefoneResponsavel2)";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@dataNascimento", aluno.DataNascimento.ToString("yyyy-MM-dd") },
                    {"@ra", aluno.Id },
                    {"@idade", aluno.Idade },
                    {"@nome", aluno.Nome },
                    {"@turmaId", aluno.Turma.Id },
                    {"@enderecoId", aluno.Endereco.Id },
                    {"@telefonePessoal", aluno.TelefonePessoal },
                    {"@telefoneFixo", aluno.TelefoneFixo },
                    {"@telefoneResponsavel", aluno.TelefoneResponsavel},
                    {"@telefoneResponsavel2", aluno.TelefoneResponsavel2 }

                };

                dataBase.ExecuteCommand(querry, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { dataBase.FecharConexao(); }
        }

        public Aluno ReceberAlunoPorId(int id)
        {
            try
            {


                string querry = "SELECT * FROM aluno a JOIN turma t ON t.ID = fk_Turma_ID WHERE a.RA = @id";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@id", id }
                };
                var resposta = dataBase.ExecuteReader(querry, parametros);

                foreach (Dictionary<string, object> linha in resposta)
                {
                    int ra = Convert.ToInt32(linha["RA"]);
                    DateTime dataNascimento = Convert.ToDateTime(linha["Data_de_Nascimento"]);
                    int idade = Convert.ToInt32(linha["Idade"]);
                    string nome = linha["Nome"].ToString();
                    int idTurma = Convert.ToInt32(linha["fk_Turma_ID"]);
                    Turma turma = turmaDAO.ReceberTurmaPorId(idTurma);
                    string telefonePessoal = linha["Telefone_Pessoal"].ToString();
                    string telefoneFixo = linha["Telefone_Fixo"].ToString();
                    string telefoneResponsavel = linha["Telefone_Responsavel"].ToString();
                    string telefoneResponsavel2 = linha["Telefone_Responsavel_2"].ToString();
                    int enderecoId = Convert.ToInt32(linha["fk_endereco_id"]);
                    Endereco endereco = enderecoDAO.ReceberEnderecoPorPessoa(enderecoId);

                    Aluno aluno = new Aluno(ra, nome, dataNascimento, idade, endereco, telefonePessoal, telefoneFixo, telefoneResponsavel, telefoneResponsavel2, turma);
                    return aluno;
                }

                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool VerificarSeRAExiste(int ra)
        {
            try
            {
                string querry = "SELECT ra FROM aluno WHERE ra = @ra";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ra", ra },
                };
                var result = dataBase.ExecuteScalar(querry, parametros);
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void AtualizarPorId(Pessoa pessoa, Pessoa pessoaAtualizada)
        {
            Aluno aluno = pessoaAtualizada as Aluno;
            Aluno alunoAntigo = pessoa as Aluno;

            try
            {

                bool bairroExiste = bairroDAO.VerificarSeBairroExiste(aluno.Endereco.Bairro);
                if (bairroExiste)
                {
                    aluno.Endereco.Bairro.Id = bairroDAO.ReceberIdBairro(aluno.Endereco.Bairro);
                    enderecoDAO.AtualizarEndereco(aluno.Endereco, alunoAntigo.Endereco);
                }
                else
                {
                    bairroDAO.CadastrarBairro(aluno.Endereco.Bairro);
                    aluno.Endereco.Bairro.Id = bairroDAO.ReceberIdUltimoBairro();
                    enderecoDAO.AtualizarEndereco(aluno.Endereco, alunoAntigo.Endereco);
                }

                string querry = $"UPDATE aluno SET Data_de_Nascimento = @dataNascimento , Idade = @idade, Nome = @nome, fk_Turma_ID = @turmaId, Telefone_Pessoal = @telefonePessoal, Telefone_Fixo = @telefoneFixo, Telefone_Responsavel = @telefoneResponsavel, Telefone_Responsavel_2 = @telefoneResponsavel2 WHERE RA = @ra";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nome", aluno.Nome },
                    {"@ra", aluno.Id},
                    {"@idade", aluno.Idade },
                    {"@dataNascimento", aluno.DataNascimento.ToString("yyyy-MM-dd")},
                    {"@turmaId", aluno.Turma.Id },
                    {"@telefonePessoal", aluno.TelefonePessoal },
                    {"@telefoneFixo", aluno.TelefoneFixo },
                    {"@telefoneResponsavel", aluno.TelefoneResponsavel  },
                    {"@telefoneResponsavel2" ,aluno.TelefoneResponsavel2 }
                };
                dataBase.ExecuteCommand(querry, parametros);
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
                provaDAO.DeletarProvaPorAluno(id);
                mediaDAO.DeletarMediaPorAluno(id);
                dataBase.AbrirConexao();
                string querry = "DELETE FROM aluno WHERE RA = @param0";
                dataBase.ExecuteCommand(querry);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { dataBase.FecharConexao(); }
        }

        public List<Aluno> BuscarAluno(string nome, int rA, int idTurma)
        {
            try
            {



                string querry = "SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE Nome LIKE @nome AND fk_Turma_ID = @ra AND RA LIKE @idTurma ";

                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nome", nome },
                    {"@ra", rA},
                    {"@idTurma", idTurma},
                };
                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(querry, parametros);
                return ListarAlunos(resultados);


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

                string querry = "SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE Nome LIKE @nome ";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nome", nome + "%"}
                };
                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(querry, parametros);
                return ListarAlunos(resultados);
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

                string querry = "SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE Nome LIKE @nome AND RA LIKE @ra ";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nome", nome + "%"},
                    {"@ra", rA+ "%"},
                };
                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(querry, parametros);
                return ListarAlunos(resultados);
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

                string querry = "SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE Nome LIKE @nome AND fk_Turma_ID = @tuma";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nome", nome+ "%"},
                    {"@tuma", idTurma }

                };
                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(querry, parametros);
                return ListarAlunos(resultados);
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

                string querry = "SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE RA LIKE @ra";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ra", rA+ "%"}
                };
                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(querry, parametros);

                return ListarAlunos(resultados);
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



                string querry = "SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE fk_Turma_ID = @idTurma AND RA LIKE @ra ";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ra", rA+ "%"},
                    {"@idTurma", idTurma }
                };
                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(querry, parametros);
                return ListarAlunos(resultados);
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



                string querry = "SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE fk_Turma_ID = @idTurma";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@idTurma", idTurma }
                };
                bool[] usarLike = { false };
                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(querry, parametros);
                return ListarAlunos(resultados);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
