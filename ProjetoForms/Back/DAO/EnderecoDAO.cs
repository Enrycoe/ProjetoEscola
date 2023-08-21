using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.DAO
{
    internal class EnderecoDAO
    {

        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;
        public int ReceberIDEndereco(Endereco endereco)
        {  
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT ID FROM endereco WHERE Nome_Rua = @nome AND Numero_Casa = @numero", conn.conn);
                cmd.Parameters.AddWithValue("@nome", endereco.NomeRua);
                cmd.Parameters.AddWithValue("@numero", endereco.NumCasa);
                var result = cmd.ExecuteScalar();
                cmd.Dispose();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal void AtualizarEndereco(Endereco endereco, Endereco enderecoAntigo)
        {
            try
            {
                int idEndereco = ReceberIDEndereco(enderecoAntigo);
                conn.AbrirConexao();
                cmd = new MySqlCommand($"UPDATE endereco SET Nome_Rua = @nome_rua, Numero_Casa = @numero_casa, fk_bairro_id = @fk_bairro_id WHERE ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@nome_rua", endereco.NomeRua);
                cmd.Parameters.AddWithValue("@numero_casa", endereco.NumCasa);   //////////////////////////////////////////////////////////////////////////////////// ARRUMA ESSA BOSTA SEU MERDA
                cmd.Parameters.AddWithValue("@fk_bairro_id", endereco.Bairro.Id);
                cmd.Parameters.AddWithValue("@ID", idEndereco);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal void CadastrarEndereco(Endereco endereco)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand($"INSERT INTO endereco(Nome_Rua, Numero_Casa, fk_bairro_id) VALUES(@nome_rua, @numero_casa, @fk_bairro_id)", conn.conn);
                cmd.Parameters.AddWithValue("@nome_rua",endereco.NomeRua);
                cmd.Parameters.AddWithValue("@numero_casa",endereco.NumCasa);
                cmd.Parameters.AddWithValue("@fk_bairro_id", endereco.Bairro.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
          
        }

        internal int ReceberIDUltimoEndereco()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand($"SELECT id FROM endereco ORDER BY id DESC LIMIT 1", conn.conn);
                var result = cmd.ExecuteScalar();
                cmd.Dispose();
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
