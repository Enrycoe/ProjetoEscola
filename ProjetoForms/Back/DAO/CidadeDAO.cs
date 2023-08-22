using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Back.DAO
{
    internal class CidadeDAO 
    {
        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;
        public List<Cidade> BuscarCidadePorEstado(int id)
        {
            try
            {
                
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM cidade WHERE fk_estado_ID = " + id, conn.conn);
                return ListarCidades(cmd);
               
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        private List<Cidade> ListarCidades (MySqlCommand cmd)
        {
            try
            {
                List<Cidade> cidades = new List<Cidade>();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    var cidade = new Cidade();
                    cidade.Estado = new Estado();
                    cidade.Estado.Id = Convert.ToInt32(dr["fk_estado_ID"]);
                    cidade.Nome = dr["Nome_Cidade"].ToString();
                    cidade.Id = Convert.ToInt32(dr["ID"]);
                    cidades.Add(cidade);
                }

                return cidades;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

      
    }
}
