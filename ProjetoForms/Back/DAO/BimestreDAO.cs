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
    public class BimestreDAO 
    {
        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;
        public List<Bimestre> BuscarBimestres()
        {
            try
            {
                

                cmd = new MySqlCommand("SELECT * FROM bimestre", conn.conn);
                return ListarBimestres(cmd);
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
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
