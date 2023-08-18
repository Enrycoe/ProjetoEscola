using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;

namespace ProjetoForms.Back.DAO
{
    internal class BairroDAO
    {

        Conection conn = new Conection();
        MySqlCommand cmd;
        public bool VerificarSeBairroExiste(Bairro bairro)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM bairro WHERE nome_bairro = @nome AND fk_cidade_id = @fk_cidade_id", conn.conn);
                cmd.Parameters.AddWithValue("@nome",bairro.Nome_bairro);
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
                cmd.Parameters.AddWithValue("@Nome_Bairro", bairro.Nome_bairro);
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

        internal int ReceberIdBairro(Bairro bairro)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT id FROM bairro where nome_bairro = @nome AND fk_cidade_id = @idCidade", conn.conn);
                cmd.Parameters.AddWithValue("@nome",bairro.Nome_bairro);
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
