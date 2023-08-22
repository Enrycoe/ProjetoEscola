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
    internal class TurmaDAO
    {
        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;
        public List<Turma> BuscarTurmas()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM turma", conn.conn);
                return ListarTurmas(cmd);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        public List<Turma> ListarTurmas(MySqlCommand cmd)
        {
            try
            {
                List<Turma> turmas = new List<Turma>();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    var turma = new Turma();
                    turma.Id = Convert.ToInt32(dr["ID"]);
                    turma.Nome = dr["Nome_Turma"].ToString();
                    turmas.Add(turma);
                }
                return turmas;

            }
            catch (Exception)
            {

                throw;
            }
            
            
        }
    }
}
