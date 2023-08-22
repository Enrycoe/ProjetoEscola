using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.DAO
{
    internal class EstadoDAO
    {
        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;
        public List<Estado> BuscarEstados()
        {
            try
            {
                
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM estado", conn.conn);
               
                return ListarEstados(cmd);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        private List<Estado> ListarEstados(MySqlCommand cmd)
        {
            try
            {
                List<Estado> estados = new List<Estado>();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    var estado = new Estado();
                    estado.Nome = dr["Nome_Estado"].ToString();
                    estado.Id = Convert.ToInt32(dr["ID"]);
                    estado.Sigla = dr["Sigla"].ToString();
                    estados.Add(estado);
                }

                return estados;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
