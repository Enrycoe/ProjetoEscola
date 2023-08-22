using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Data;

namespace ProjetoForms.Back.DAO
{
    internal class BairroDAO
    {

        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;
        CidadeDAO cidadeDAO = new CidadeDAO();
       
        public bool VerificarSeBairroExiste(Bairro bairro)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM bairro WHERE nome_bairro = @nome AND fk_cidade_id = @fk_cidade_id", conn.conn);
                cmd.Parameters.AddWithValue("@nome",bairro.NomeBairro);
                cmd.Parameters.AddWithValue("@fk_cidade_id", bairro.Cidade.Id);
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal void CadastrarBairro(Bairro bairro)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("INSERT INTO bairro (Nome_Bairro, fk_cidade_id) VALUES (@Nome_Bairro, @fk_cidade_id)", conn.conn);
                cmd.Parameters.AddWithValue("@Nome_Bairro", bairro.NomeBairro);
                cmd.Parameters.AddWithValue("@fk_cidade_id", bairro.Cidade.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
            
        }

        internal Bairro ReceberBairroPorId(int id)
        {
            try
            {
                var bairro = new Bairro();
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM bairro WHERE ID = @estadoEndereco", conn.conn);
                cmd.Parameters.AddWithValue("@estadoEndereco", id);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    
                    bairro.Id = id;
                    bairro.NomeBairro = dr["Nome_Bairro"].ToString();
                    int idCidade = Convert.ToInt32(dr["fk_cidade_id"]);
                    bairro.Cidade = cidadeDAO.ReceberCidadePorId(idCidade);
                }
                cmd.Dispose();
                return bairro;
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao(); }
        }

        internal int ReceberIdBairro(Bairro bairro)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT id FROM bairro where nome_bairro = @nome AND fk_cidade_id = @idCidade", conn.conn);
                cmd.Parameters.AddWithValue("@nome",bairro.NomeBairro);
                cmd.Parameters.AddWithValue("@idCidade", bairro.Cidade.Id);
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal int ReceberIdUltimoBairro()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand($"SELECT id FROM bairro ORDER BY id DESC LIMIT 1", conn.conn);
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
            
        }
    }
}
