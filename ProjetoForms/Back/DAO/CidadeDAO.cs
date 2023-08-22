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
        EstadoDAO estadoDAO = new EstadoDAO();
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

        internal Cidade ReceberCidadePorId(int idCidade)
        {
            try
            {
                var cidade = new Cidade();
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM cidade WHERE ID = @idCidade", conn.conn);
                cmd.Parameters.AddWithValue("@idCidade", idCidade);
                MySqlDataAdapter adapter = new MySqlDataAdapter();             
                DataTable dt = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    
                    cidade.Id = idCidade;
                    cidade.Nome = dr["Nome_Cidade"].ToString();
                    int idEstado = Convert.ToInt32(dr["fk_Estado_ID"]);
                    cidade.Estado = estadoDAO.ReceberEstadoPorId(idEstado);
                }
                cmd.Dispose();
                return cidade;
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao() ; }
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
