using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using ProjetoForms.Back.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Back.DAO
{
    public class ProfessorDAO
    {
        UsuarioDAO usuarioDAO;
        EnderecoDAO enderecoDAO;
        TurmaDAO turmaDAO;
        MateriaDAO materiaDAO;
        BairroDAO bairroDAO;
        ConexaoMySQL conn;
        MySqlCommand cmd;

        public ProfessorDAO()
        {

            enderecoDAO = new EnderecoDAO();
            turmaDAO = new TurmaDAO();
            materiaDAO = new MateriaDAO();
            bairroDAO = new BairroDAO();
            conn = new ConexaoMySQL();
        }
        public void Atualizar(Pessoa pessoa, Pessoa pessoaAtualizada)
        {

            Professor professor = pessoa as Professor;
            Professor professorAtualizada = pessoaAtualizada as Professor;
            try
            {


                bool bairroExiste = bairroDAO.VerificarSeBairroExiste(professorAtualizada.Endereco.Bairro);
                if (bairroExiste)
                {
                    professorAtualizada.Endereco.Bairro.Id = bairroDAO.ReceberIdBairro(professorAtualizada.Endereco.Bairro);
                    enderecoDAO.AtualizarEndereco(professorAtualizada.Endereco, professor.Endereco);
                }
                else
                {
                    bairroDAO.CadastrarBairro(professorAtualizada.Endereco.Bairro);
                    professorAtualizada.Endereco.Bairro.Id = bairroDAO.ReceberIdUltimoBairro();
                    enderecoDAO.AtualizarEndereco(professorAtualizada.Endereco, professor.Endereco);
                }
                DeletarMateriaDoProfessorPorId(professor.Id);
                DeletarTurmadoProfessorPorId(professor.Id);
                conn.AbrirConexao();
                foreach (Materia materia in professorAtualizada.Materias)
                {
                    cmd = new MySqlCommand("INSERT INTO materia_professor (fk_Materia_ID, fk_Professor_ID) VALUES (@materia, @professor)", conn.conn);
                    cmd.Parameters.AddWithValue("@materia", materia.Id);
                    cmd.Parameters.AddWithValue("@professor", professorAtualizada.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                foreach (Turma turma in professorAtualizada.Turmas)
                {
                    cmd = new MySqlCommand("INSERT INTO professor_turma (fk_Turma_ID, fk_Professor_ID) VALUES (@turma, @professor)", conn.conn);
                    cmd.Parameters.AddWithValue("@turma", turma.Id);
                    cmd.Parameters.AddWithValue("@professor", professorAtualizada.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                cmd = new MySqlCommand($"UPDATE professor SET Data_de_Nascimento = @Data_de_Nascimento , Idade = @Idade, Nome = @nome, Telefone_Pessoal = @Telefone_Pessoal, Telefone_Fixo = @Telefone_Fixo WHERE ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@Data_de_Nascimento", professorAtualizada.DataNascimento.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@ID", professorAtualizada.Id);
                cmd.Parameters.AddWithValue("@Idade", professorAtualizada.Idade);
                cmd.Parameters.AddWithValue("@nome", professorAtualizada.Nome);
                cmd.Parameters.AddWithValue("@Telefone_Pessoal", professorAtualizada.TelefonePessoal);
                cmd.Parameters.AddWithValue("@Telefone_Fixo", professorAtualizada.TelefoneFixo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        public List<Professor> BuscarPorNome(string nome)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM professor WHERE Nome LIKE @nome", conn.conn);
                cmd.Parameters.AddWithValue("@nome", nome + "%");

                return ListarProfessores(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        public void Cadastrar(Pessoa pessoa, int idUsuario)
        {
            Professor professor = pessoa as Professor;
            try
            {
                bool bairroExiste = bairroDAO.VerificarSeBairroExiste(professor.Endereco.Bairro);
                if (bairroExiste)
                {
                    professor.Endereco.Bairro.Id = bairroDAO.ReceberIdBairro(professor.Endereco.Bairro);
                    enderecoDAO.CadastrarEndereco(professor.Endereco);
                    professor.Endereco.Id = enderecoDAO.ReceberIDUltimoEndereco();
                }
                else
                {
                    bairroDAO.CadastrarBairro(professor.Endereco.Bairro);
                    professor.Endereco.Bairro.Id = bairroDAO.ReceberIdUltimoBairro();
                    enderecoDAO.CadastrarEndereco(professor.Endereco);
                    professor.Endereco.Id = enderecoDAO.ReceberIDUltimoEndereco();

                }
                conn.AbrirConexao();
                cmd = new MySqlCommand($"INSERT INTO professor (Idade, Data_de_Nascimento, fk_Endereço_ID,  Telefone_Pessoal, Telefone_Fixo, Nome, fk_Usuario_ID) " +
                       $"VALUES(@Idade, @Data_de_Nascimento, @fk_endereco_id, @Telefone_Pessoal, @Telefone_Fixo, @nome, @idUsuario)", conn.conn);
                cmd.Parameters.AddWithValue("@Data_de_Nascimento", professor.DataNascimento.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Idade", professor.Idade);
                cmd.Parameters.AddWithValue("@nome", professor.Nome);
                cmd.Parameters.AddWithValue("@fk_endereco_id", professor.Endereco.Id);
                cmd.Parameters.AddWithValue("@Telefone_Pessoal", professor.TelefonePessoal);
                cmd.Parameters.AddWithValue("@Telefone_Fixo", professor.TelefoneFixo);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.FecharConexao();
                professor.Id = ReceberIdUltimoProfessor();
                cmd.Dispose();
                foreach (Materia materia in professor.Materias)
                {
                    conn.AbrirConexao();
                    cmd = new MySqlCommand("INSERT INTO materia_professor(fk_Materia_ID, fk_Professor_ID) VALUES (@materia, @professor)", conn.conn);
                    cmd.Parameters.AddWithValue("@materia", materia.Id);
                    cmd.Parameters.AddWithValue("@professor", professor.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.FecharConexao();
                }

                foreach (Turma turma in professor.Turmas)
                {
                    conn.AbrirConexao();
                    cmd = new MySqlCommand("INSERT INTO professor_turma(fk_Turma_ID, fk_Professor_ID) VALUES (@turma, @professor)", conn.conn);
                    cmd.Parameters.AddWithValue("@turma", turma.Id);
                    cmd.Parameters.AddWithValue("@professor", professor.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.FecharConexao();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        public int ReceberIdUltimoProfessor()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT id FROM professor ORDER BY id DESC LIMIT 1", conn.conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao(); }
        }

        public void DeletarMateriaDoProfessorPorId(int id)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("DELETE FROM materia_professor WHERE fk_Professor_ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        public void DeletarTurmadoProfessorPorId(int id)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("DELETE FROM professor_turma WHERE fk_Professor_ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }
        public void DeletarPorId(int id)
        {
            try
            {
                usuarioDAO = new UsuarioDAO();
                DeletarMateriaDoProfessorPorId(id);
                DeletarTurmadoProfessorPorId(id);
                Professor professor = ReceberProfessorPorId(id);
                Usuario usuario = usuarioDAO.ReceberUsuarioPorProfessor(professor);
                conn.AbrirConexao();
                cmd = new MySqlCommand("DELETE FROM professor WHERE ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                usuarioDAO.DeletarLoginPorUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { conn.FecharConexao(); }
        }



        public List<Professor> BuscarTodosProfessores()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM professor", conn.conn);


                return ListarProfessores(cmd);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        private List<Professor> ListarProfessores(MySqlCommand cmd)
        {
            List<Professor> professores = new List<Professor>();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["ID"]);
                DateTime dataNascimento = Convert.ToDateTime(dr["Data_de_Nascimento"]);
                int idade = Convert.ToInt32(dr["Idade"]);
                string nome = dr["Nome"].ToString();
                string telefonePessoal = dr["Telefone_Pessoal"].ToString();
                string telefoneFixo = dr["Telefone_Fixo"].ToString();
                int idEndereco = Convert.ToInt32(dr["fk_endereço_id"]);
                Endereco endereco = enderecoDAO.ReceberEnderecoPorPessoa(idEndereco);
                List<Turma> turmas = turmaDAO.BuscarTurmasPorProfessor(id);
                List<Materia> materias = materiaDAO.BuscarMateriaPorProfessor(id);
                Professor professor = new Professor(id, nome, dataNascimento, idade, endereco, telefonePessoal, telefoneFixo, materias, turmas);
                professores.Add(professor);
            }
            return professores;
        }

        public Professor ReceberProfessorPorId(int id)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM professor p WHERE p.ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID", id);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    DateTime dataNascimento = Convert.ToDateTime(reader["Data_de_Nascimento"]);
                    int idade = Convert.ToInt32(reader["Idade"]);
                    string nome = reader["Nome"].ToString();
                    string telefonePessoal = reader["Telefone_Pessoal"].ToString();
                    string telefoneFixo = reader["Telefone_Fixo"].ToString();
                    int idEndereco = Convert.ToInt32(reader["fk_endereço_id"]);
                    Endereco endereco = enderecoDAO.ReceberEnderecoPorPessoa(idEndereco);
                    List<Turma> turmas = turmaDAO.BuscarTurmasPorProfessor(id);
                    List<Materia> materias = materiaDAO.BuscarMateriaPorProfessor(id);
                    Professor professor = new Professor(id, nome, dataNascimento, idade, endereco, telefonePessoal, telefoneFixo, materias, turmas);
                    return professor;
                }
                cmd.Dispose();
                return null;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

       
        public Professor ReceberProfessorPorUsuarioID(int id)
        {
            try
            {

                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM professor p WHERE p.fk_Usuario_ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID", id);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    DateTime dataNascimento = Convert.ToDateTime(reader["Data_de_Nascimento"]);
                    int idade = Convert.ToInt32(reader["Idade"]);
                    string nome = reader["Nome"].ToString();
                    string telefonePessoal = reader["Telefone_Pessoal"].ToString();
                    string telefoneFixo = reader["Telefone_Fixo"].ToString();
                    int idEndereco = Convert.ToInt32(reader["fk_endereço_id"]);
                    Endereco endereco = enderecoDAO.ReceberEnderecoPorPessoa(idEndereco);
                    List<Turma> turmas = turmaDAO.BuscarTurmasPorProfessor(id);
                    List<Materia> materias = materiaDAO.BuscarMateriaPorProfessor(id);
                    Professor professor = new Professor(id, nome, dataNascimento, idade, endereco, telefonePessoal, telefoneFixo, materias, turmas);
                    return professor;
                }
                cmd.Dispose();
                return null;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

    }

}

