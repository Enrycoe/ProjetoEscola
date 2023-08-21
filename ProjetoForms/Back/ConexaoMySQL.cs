using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back
{
    internal class ConexaoMySQL 
    {
        string conexao = "SERVER=localhost; DATABASE=db_escola; USER=root; PASSWORD=Enrycoe23042003@;";
        public MySqlConnection conn = null;



        public void AbrirConexao()
        {
            try
            {
                conn = new MySqlConnection(conexao);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void FecharConexao()
        {
            try
            {
                conn = new MySqlConnection(conexao);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

