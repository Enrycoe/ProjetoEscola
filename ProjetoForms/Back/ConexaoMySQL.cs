using MySql.Data.MySqlClient;
using ProjetoForms.Back;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms
{
    internal class ConexaoMySQL : IDBConnection
    {
        string strConnection = "server=127.0.0.1;User Id=root;database = db_escola;password=Enrycoe23042003@";
        public MySqlConnection conn = null;


        public void AbrirConexao()
        {
            try
            {
                conn = new MySqlConnection(strConnection);
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
                conn = new MySqlConnection(strConnection);
                conn.Close();
            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }
    }
}
