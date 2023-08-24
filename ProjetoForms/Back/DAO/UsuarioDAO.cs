using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoForms.Back.DAO
{
    internal class UsuarioDAO
    {
        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;

        
        internal int GerarERetornarLogin(string nome)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("INSERT INTO usuario (Usuario, Senha, fk_Tipo_Usuario) VALUES (@nome, 123, 2)", conn.conn);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return RetornarIDUltimoUsuario();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao(); }
        }

        private int RetornarIDUltimoUsuario()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand($"SELECT id FROM usuario ORDER BY id DESC LIMIT 1", conn.conn);
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal Usuario ReceberUsuario(string nome, string senha)
        {
            try
            {
                ProfessorDAO professorDAO = new ProfessorDAO();
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM usuario u WHERE Usuario = @usuario AND Senha = @senha", conn.conn);
                cmd.Parameters.AddWithValue("@usuario", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    string nomeUsuario = dr["Usuario"].ToString();
                    string senhaUsuario = dr["Senha"].ToString();
                    int tipoUsuario = Convert.ToInt32(dr["fk_Tipo_Usuario"]);
                    int id = Convert.ToInt32(dr["ID"]);
                    Professor professor = professorDAO.ReceberProfessorPorUsuarioID(id);
                    Usuario usuario = new Usuario(id, nomeUsuario, senhaUsuario, tipoUsuario, professor);
                    return usuario;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao(); }
        }

        internal Usuario ReceberUsuarioPorProfessor(Professor professor)
        {
            try
            {
                
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM usuario u JOIN professor p ON p.fk_Usuario_ID = u.ID WHERE p.ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID", professor.Id);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string nomeUsuario = dr["Usuario"].ToString();             
                    string senhaUsuario = dr["Senha"].ToString();
                    int tipoUsuario = Convert.ToInt32(dr["fk_Tipo_Usuario"]);
                    int id = Convert.ToInt32(dr["ID"]);
                    Usuario usuario = new Usuario(id, nomeUsuario, senhaUsuario, tipoUsuario, professor);
                    return usuario;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao(); }
        }

        internal bool VerificarSeLoginExiste(string login)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT Usuario FROM usuario WHERE Usuario = @login", conn.conn);
                cmd.Parameters.AddWithValue("@login", login);
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

        internal bool VerificarSeTrocouASenha(string senha, string login)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT Senha FROM usuario WHERE Usuario = @login AND Senha = @senha", conn.conn);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@login", login);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { conn.FecharConexao(); }
        }

        public void DeletarLoginPorUsuario(Usuario usuario)
        {
            try
            {
        
                
                conn.AbrirConexao();
                cmd = new MySqlCommand("DELETE FROM usuario WHERE ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID", usuario.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { conn.FecharConexao(); }
        }
        internal void AlterarSenha(string senha, string login)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("UPDATE usuario SET Senha = @senha WHERE Usuario = @login", conn.conn);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { conn.FecharConexao(); }
        }
    }
}
