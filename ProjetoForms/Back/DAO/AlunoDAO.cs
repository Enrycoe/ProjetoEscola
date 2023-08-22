using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoForms.Back.Entities;
using System.Windows.Forms;

namespace ProjetoForms.Back.DAO
{
    public class AlunoDAO
    {
        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;
        BairroDAO bairroDAO = new BairroDAO();
        EnderecoDAO enderecoDAO = new EnderecoDAO();
        ProvaDAO provaDAO = new ProvaDAO();
        MediaDAO mediaDAO = new MediaDAO();
        public List<Aluno> BuscarTodosAlunos()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID", conn.conn);

                return ListarAlunos(cmd);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        private List<Aluno> ListarAlunos(MySqlCommand cmd)
        {
            try
            {
                List<Aluno> alunos = new List<Aluno>();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    var aluno = new Aluno();
                    aluno.Endereco = new Endereco();
                    aluno.Endereco.Bairro = new Bairro();
                    aluno.Endereco.Bairro.Cidade = new Cidade();
                    aluno.Endereco.Bairro.Cidade.Estado = new Estado();
                    aluno.Turma = new Turma();

                    aluno.Id = Convert.ToInt32(dr["RA"]);
                    aluno.DataNascimento = Convert.ToDateTime(dr["Data_de_Nascimento"]);
                    aluno.Idade = Convert.ToInt32(dr["Idade"]);
                    aluno.Nome = dr["Nome"].ToString();
                    aluno.Turma.Id = Convert.ToInt32(dr["fk_Turma_ID"]);
                    aluno.TelefonePessoal = dr["Telefone_Pessoal"].ToString();
                    aluno.TelefoneFixo = dr["Telefone_Fixo"].ToString();
                    aluno.TelefoneResponsavel = dr["Telefone_Responsavel"].ToString();
                    aluno.TelefoneResponsavel2 = dr["Telefone_Responsavel_2"].ToString();
                    aluno.Endereco.Id = Convert.ToInt32(dr["fk_endereco_ID"]);
                    aluno.Turma.Nome = dr["Nome_Turma"].ToString();


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
                conn.AbrirConexao();
                cmd = new MySqlCommand($"INSERT INTO aluno(Data_de_Nascimento, RA, Idade, Nome, fk_Turma_ID, fk_Endereco_ID, Telefone_Pessoal, Telefone_Fixo, Telefone_Responsavel, Telefone_Responsavel_2) " +
                       $"VALUES(@Data_de_Nascimento, @RA, @Idade, @nome, @fk_turma_id, @fk_endereco_id, @Telefone_Pessoal, @Telefone_Fixo, @Telefone_Responsavel, @Telefone_Responsavel_2)", conn.conn);
                cmd.Parameters.AddWithValue("@Data_de_Nascimento", aluno.DataNascimento.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@RA", aluno.Id);
                cmd.Parameters.AddWithValue("@Idade", aluno.Idade);
                cmd.Parameters.AddWithValue("@nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@fk_turma_id", aluno.Turma.Id);
                cmd.Parameters.AddWithValue("@fk_endereco_id", aluno.Endereco.Id);
                cmd.Parameters.AddWithValue("@Telefone_Pessoal", aluno.TelefonePessoal);
                cmd.Parameters.AddWithValue("@Telefone_Fixo", aluno.TelefoneFixo);
                cmd.Parameters.AddWithValue("@Telefone_Responsavel", aluno.TelefoneResponsavel);
                cmd.Parameters.AddWithValue("@Telefone_Responsavel_2", aluno.TelefoneResponsavel2);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        public Aluno ReceberAlunoPorId(int id)
        {
            try
            {
                Aluno aluno = new Aluno();
                aluno.Turma = new Turma();
                aluno.Endereco = new Endereco();
                aluno.Endereco.Bairro = new Bairro();
                aluno.Endereco.Bairro.Cidade = new Cidade();
                aluno.Endereco.Bairro.Cidade.Estado = new Estado();
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM aluno a \r\nJOIN turma t ON t.ID = fk_Turma_ID \r\nJOIN endereco e ON a.fk_endereco_id = e.ID\r\nJOIN bairro b ON e.fk_bairro_id = b.ID\r\nJOIN cidade c ON b.fk_cidade_id = c.ID\r\nJOIN estado es ON c.fk_Estado_ID = es.ID\r\nWHERE a.RA = @RA", conn.conn);
                cmd.Parameters.AddWithValue("@RA", id);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    aluno.Id = Convert.ToInt32(reader["RA"]);
                    aluno.DataNascimento = Convert.ToDateTime(reader["Data_de_Nascimento"]);
                    aluno.Idade = Convert.ToInt32(reader["Idade"]);
                    aluno.Nome = reader["Nome"].ToString();
                    aluno.Turma.Id = Convert.ToInt32(reader["fk_Turma_ID"]);
                    aluno.TelefonePessoal = reader["Telefone_Pessoal"].ToString();
                    aluno.TelefoneFixo = reader["Telefone_Fixo"].ToString();
                    aluno.TelefoneResponsavel = reader["Telefone_Responsavel"].ToString();
                    aluno.TelefoneResponsavel2 = reader["Telefone_Responsavel_2"].ToString();
                    aluno.Endereco.Id = Convert.ToInt32(reader["fk_endereco_ID"]);
                    aluno.Turma.Nome = reader["Nome_Turma"].ToString();
                    aluno.Endereco.NomeRua = reader["Nome_Rua"].ToString();
                    aluno.Endereco.NumCasa = Convert.ToInt32(reader["Numero_Casa"]);
                    aluno.Endereco.Bairro.Id = Convert.ToInt32(reader["fk_bairro_id"]);
                    aluno.Endereco.Bairro.NomeBairro = reader["Nome_Bairro"].ToString();
                    aluno.Endereco.Bairro.Cidade.Id = Convert.ToInt32(reader["fk_cidade_id"]);
                    aluno.Endereco.Bairro.Cidade.Nome = reader["Nome_Cidade"].ToString();
                    aluno.Endereco.Bairro.Cidade.Estado.Id = Convert.ToInt32(reader["fk_Estado_ID"]);
                    aluno.Endereco.Bairro.Cidade.Estado.Sigla = reader["Sigla"].ToString();
                    aluno.Endereco.Bairro.Cidade.Estado.Nome = reader["Nome_Estado"].ToString();
                }


                return aluno;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }


        public bool VerificarSeRAExiste(int ra)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT ra FROM aluno WHERE ra = @ra", conn.conn);
                cmd.Parameters.AddWithValue("@ra", ra);
                var result = cmd.ExecuteScalar();
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

            finally { conn.FecharConexao(); }
        }

        internal void AtualizarPorId(Pessoa pessoa, Pessoa pessoaAtualizada)
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
                conn.AbrirConexao();
                cmd = new MySqlCommand($"UPDATE aluno SET Data_de_Nascimento = @Data_de_Nascimento , Idade = @Idade, Nome = @nome, fk_Turma_ID = @fk_turma_id, Telefone_Pessoal = @Telefone_Pessoal, Telefone_Fixo = @Telefone_Fixo, Telefone_Responsavel = @Telefone_Responsavel, Telefone_Responsavel_2 = @Telefone_Responsavel_2 WHERE RA = @RA", conn.conn);
                cmd.Parameters.AddWithValue("@Data_de_Nascimento", aluno.DataNascimento.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@RA", aluno.Id);
                cmd.Parameters.AddWithValue("@Idade", aluno.Idade);
                cmd.Parameters.AddWithValue("@nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@fk_turma_id", aluno.Turma.Id);
                cmd.Parameters.AddWithValue("@Telefone_Pessoal", aluno.TelefonePessoal);
                cmd.Parameters.AddWithValue("@Telefone_Fixo", aluno.TelefoneFixo);
                cmd.Parameters.AddWithValue("@Telefone_Responsavel", aluno.TelefoneResponsavel);
                cmd.Parameters.AddWithValue("@Telefone_Responsavel_2", aluno.TelefoneResponsavel2);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal void DeletarPorId(int id)
        {
            try
            {
                provaDAO.DeletarProvaPorAluno(id);
                mediaDAO.DeletarMediaPorAluno(id);
                conn.AbrirConexao();
                cmd = new MySqlCommand("DELETE FROM aluno WHERE RA = @RA", conn.conn);
                cmd.Parameters.AddWithValue("@RA", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal List<Aluno> BuscarAluno(string nome, int rA, int idTurma)
        {
            try
            {
                conn.AbrirConexao();
                if (idTurma == 13)
                {
                    cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE Nome LIKE @nome AND RA LIKE @RA ", conn.conn);
                    cmd.Parameters.AddWithValue("@nome", nome + "%");
                    cmd.Parameters.AddWithValue("@RA", rA + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return ListarAlunos(cmd);
                }
                else
                {
                    cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE Nome LIKE @nome AND fk_Turma_ID = @fk_turma_id AND RA LIKE @RA ", conn.conn);
                    cmd.Parameters.AddWithValue("@nome", nome + "%");
                    cmd.Parameters.AddWithValue("@fk_turma_id", idTurma + "%");
                    cmd.Parameters.AddWithValue("@RA", rA + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return ListarAlunos(cmd);
                }

            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal List<Aluno> BuscarAlunoPorNome(string nome)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE Nome LIKE @nome", conn.conn);
                cmd.Parameters.AddWithValue("@nome", nome + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return ListarAlunos(cmd);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal List<Aluno> BuscarAlunoPorNomeERA(string nome, int rA)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE Nome LIKE @nome AND RA LIKE @RA ", conn.conn);
                cmd.Parameters.AddWithValue("@nome", nome + "%");
                cmd.Parameters.AddWithValue("@RA", rA + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                return ListarAlunos(cmd);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal List<Aluno> BuscarAlunoPorNomeETurma(string nome, int idTurma)
        {
            try
            {
                conn.AbrirConexao();
                if (idTurma == 13)
                {
                    cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE Nome LIKE @nome", conn.conn);
                    cmd.Parameters.AddWithValue("@nome", nome + "%");
                    cmd.Parameters.AddWithValue("@fk_turma_id", idTurma + "%");
                    return ListarAlunos(cmd);
                }
                else
                {
                    cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE Nome LIKE @nome AND fk_Turma_ID = @fk_turma_id", conn.conn);
                    cmd.Parameters.AddWithValue("@nome", nome + "%");
                    cmd.Parameters.AddWithValue("@fk_turma_id", idTurma + "%");
                    return ListarAlunos(cmd);
                }

            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal List<Aluno> BuscarAlunoPorRA(int rA)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE RA LIKE @RA ", conn.conn);
                cmd.Parameters.AddWithValue("@RA", rA + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return ListarAlunos(cmd);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal List<Aluno> BuscarAlunoPorRAETurma(int rA, int idTurma)
        {
            try
            {
                conn.AbrirConexao();
                if (idTurma == 13)
                {
                    cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE RA LIKE @RA ", conn.conn);
                    cmd.Parameters.AddWithValue("@fk_turma_id", idTurma + "%");
                    cmd.Parameters.AddWithValue("@RA", rA + "%");
                    return ListarAlunos(cmd);
                }
                else
                {
                    cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE fk_Turma_ID = @fk_turma_id AND RA LIKE @RA ", conn.conn);
                    cmd.Parameters.AddWithValue("@fk_turma_id", idTurma + "%");
                    cmd.Parameters.AddWithValue("@RA", rA + "%");
                    return ListarAlunos(cmd);
                }

            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal List<Aluno> BuscarAlunoPorTurma(int idTurma)
        {
            try
            {
                conn.AbrirConexao();
                if (idTurma == 13)
                {
                    cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID", conn.conn);
                    cmd.Parameters.AddWithValue("@fk_turma_id", idTurma + "%");
                    return ListarAlunos(cmd);
                }
                else
                {
                    cmd = new MySqlCommand("SELECT aluno.*, turma.Nome_Turma FROM aluno JOIN turma ON turma.ID = fk_Turma_ID WHERE fk_Turma_ID = @fk_turma_id", conn.conn);
                    cmd.Parameters.AddWithValue("@fk_turma_id", idTurma + "%");
                    return ListarAlunos(cmd);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }
    }
}
