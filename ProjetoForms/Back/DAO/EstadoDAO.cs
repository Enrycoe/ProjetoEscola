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

        internal Estado ReceberEstadoPorId(int idEstado)
        {
            try
            {
               
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM estado WHERE ID = @idEstado", conn.conn);
                cmd.Parameters.AddWithValue("@idEstado", idEstado);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    
                    
                    string nome = dr["Nome_Estado"].ToString();
                    string sigla = dr["Sigla"].ToString();
                    Estado estado = new Estado(idEstado, nome, sigla);
                    return estado;
                }
                cmd.Dispose();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao();}
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
                    
                    string nome = dr["Nome_Estado"].ToString();
                    int id = Convert.ToInt32(dr["ID"]);
                    string sigla = dr["Sigla"].ToString();
                    Estado estado = new Estado(id, nome, sigla);
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
