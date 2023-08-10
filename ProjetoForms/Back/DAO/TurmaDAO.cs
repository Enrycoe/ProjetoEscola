using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.DAO
{
    internal class TurmaDAO
    {
        Conection conn = new Conection();
        MySqlCommand cmd;
        public DataTable Listar()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM turma", conn.conn);
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
