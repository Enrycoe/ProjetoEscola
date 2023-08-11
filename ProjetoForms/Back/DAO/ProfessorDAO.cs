using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Back.DAO
{
    internal class ProfessorDAO
    {
        Conection conn = new Conection();
        MySqlCommand cmd;

        internal void Atualizar(Pessoa pessoaAtualizada, Pessoa pessoa)
        {
            Professor professor = pessoa as Professor;
            Professor professorAtualizada = pessoaAtualizada as Professor;
            EnderecoDAO enderecoDAO = new EnderecoDAO();

            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT id FROM bairro where nome_bairro = @nome AND fk_cidade_id = @idCidade", conn.conn);
                cmd.Parameters.AddWithValue("@nome", professorAtualizada.Endereco.Bairro.Nome_bairro);
                cmd.Parameters.AddWithValue("@idCidade", professorAtualizada.Endereco.Bairro.Cidade.Id);
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    professorAtualizada.Endereco.Bairro.Id = Convert.ToInt32(result);
                    cmd = new MySqlCommand($"UPDATE endereco SET Nome_Rua = @nome_rua, Numero_Casa = @numero_casa, fk_bairro_id = @fk_bairro_id WHERE ID = @ID", conn.conn);
                    cmd.Parameters.AddWithValue("@nome_rua", professorAtualizada.Endereco.NomeRua);
                    cmd.Parameters.AddWithValue("@numero_casa", professorAtualizada.Endereco.NumCasa);
                    cmd.Parameters.AddWithValue("@fk_bairro_id", professorAtualizada.Endereco.Bairro.Id);
                    cmd.Parameters.AddWithValue("@ID", enderecoDAO.ReceberIDEndereco(professor));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                else
                {
                    cmd = new MySqlCommand("INSERT INTO bairro (Nome_Bairro, fk_cidade_id) VALUES (@Nome_Bairro, @fk_cidade_id)", conn.conn);
                    cmd.Parameters.AddWithValue("@Nome_Bairro", professorAtualizada.Endereco.Bairro.Nome_bairro);
                    cmd.Parameters.AddWithValue("@fk_cidade_id", professorAtualizada.Endereco.Bairro.Cidade.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = new MySqlCommand($"SELECT id FROM bairro ORDER BY id DESC LIMIT 1", conn.conn);
                    professorAtualizada.Endereco.Bairro.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                    cmd = new MySqlCommand($"UPDATE endereco SET Nome_Rua = @nome_rua, Numero_Casa = @numero_casa, fk_bairro_id = @fk_bairro_id WHERE ID = @ID", conn.conn);
                    cmd.Parameters.AddWithValue("@nome_rua", professorAtualizada.Endereco.NomeRua);
                    cmd.Parameters.AddWithValue("@numero_casa", professorAtualizada.Endereco.NumCasa);
                    cmd.Parameters.AddWithValue("@fk_bairro_id", professorAtualizada.Endereco.Bairro.Id);
                    cmd.Parameters.AddWithValue("@ID", enderecoDAO.ReceberIDEndereco(professor));
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
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao(); }
        }
        internal void Cadastrar(Pessoa pessoa)
        {
            Professor professor = pessoa as Professor;
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT id FROM bairro where nome_bairro = @nome", conn.conn);
                cmd.Parameters.AddWithValue("@nome", professor.Endereco.Bairro.Nome_bairro);
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    professor.Endereco.Bairro.Id = Convert.ToInt32(result);
                    cmd = new MySqlCommand($"INSERT INTO endereco(Nome_Rua, Numero_Casa, fk_bairro_id) VALUES(@nome_rua, @numero_casa, @fk_bairro_id)", conn.conn);
                    cmd.Parameters.AddWithValue("@nome_rua", professor.Endereco.NomeRua);
                    cmd.Parameters.AddWithValue("@numero_casa", professor.Endereco.NumCasa);
                    cmd.Parameters.AddWithValue("@fk_bairro_id", professor.Endereco.Bairro.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = new MySqlCommand($"SELECT id FROM endereco ORDER BY id DESC LIMIT 1", conn.conn);
                    professor.Endereco.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                }
                else
                {
                    cmd = new MySqlCommand("INSERT INTO bairro (Nome_Bairro, fk_cidade_id) VALUES (@Nome_Bairro, @fk_cidade_id)", conn.conn);
                    cmd.Parameters.AddWithValue("@Nome_Bairro", professor.Endereco.Bairro.Nome_bairro);
                    cmd.Parameters.AddWithValue("@fk_cidade_id", professor.Endereco.Bairro.Cidade.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = new MySqlCommand($"SELECT id FROM bairro ORDER BY id DESC LIMIT 1", conn.conn);
                    professor.Endereco.Bairro.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                    cmd = new MySqlCommand($"INSERT INTO endereco(Nome_Rua, Numero_Casa, fk_bairro_id) VALUES(@nome_rua, @numero_casa, @fk_bairro_id)", conn.conn);
                    cmd.Parameters.AddWithValue("@nome_rua", professor.Endereco.NomeRua);
                    cmd.Parameters.AddWithValue("@numero_casa", professor.Endereco.NumCasa);
                    cmd.Parameters.AddWithValue("@fk_bairro_id", professor.Endereco.Bairro.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = new MySqlCommand($"SELECT id FROM endereco ORDER BY id DESC LIMIT 1", conn.conn);
                    professor.Endereco.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();

                }
                cmd = new MySqlCommand($"INSERT INTO professor (Idade, Data_de_Nascimento, fk_Endereço_ID,  Telefone_Pessoal, Telefone_Fixo, Nome) " +
                       $"VALUES(@Idade, @Data_de_Nascimento, @fk_endereco_id, @Telefone_Pessoal, @Telefone_Fixo, @nome)", conn.conn);
                cmd.Parameters.AddWithValue("@Data_de_Nascimento", professor.DataNascimento.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Idade", professor.Idade);
                cmd.Parameters.AddWithValue("@nome", professor.Nome);
                cmd.Parameters.AddWithValue("@fk_endereco_id", professor.Endereco.Id);
                cmd.Parameters.AddWithValue("@Telefone_Pessoal", professor.TelefonePessoal);
                cmd.Parameters.AddWithValue("@Telefone_Fixo", professor.TelefoneFixo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                cmd = new MySqlCommand("SELECT id FROM professor ORDER BY id DESC LIMIT 1", conn.conn);
                professor.Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                foreach (Materia materia in professor.Materias)
                {
                    cmd = new MySqlCommand("INSERT INTO materia_professor(fk_Materia_ID, fk_Professor_ID) VALUES (@materia, @professor)", conn.conn);
                    cmd.Parameters.AddWithValue("@materia", materia.Id);
                    cmd.Parameters.AddWithValue("@professor", professor.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                foreach (Turma turma in professor.Turmas)
                {
                    cmd = new MySqlCommand("INSERT INTO professor_turma(fk_Turma_ID, fk_Professor_ID) VALUES (@turma, @professor)", conn.conn);
                    cmd.Parameters.AddWithValue("@turma", turma.Id);
                    cmd.Parameters.AddWithValue("@professor", professor.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
            finally { conn.FecharConexao(); }
        }

        internal DataTable Listar()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM professor", conn.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }

            catch (Exception)
            {
                throw;
            }
            finally { conn.FecharConexao(); }
        }
    }


}

