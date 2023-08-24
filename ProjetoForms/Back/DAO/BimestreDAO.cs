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
    internal class BimestreDAO 
    {
        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;
        internal List<Bimestre> BuscarBimestres() //////transforma em lista seu viado
        {
            try
            {
                
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM bimestre", conn.conn);
                return ListarBimestres(cmd);
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        private List<Bimestre> ListarBimestres(MySqlCommand cmd)
        {
            try
            {
                List<Bimestre> bimestres = new List<Bimestre>();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    
                    string nome = dr["bimestre"].ToString();
                    int id = Convert.ToInt32(dr["id"]);
                    Bimestre bimestre = new Bimestre(id, nome);
                    bimestres.Add(bimestre);
                }
                return bimestres;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
