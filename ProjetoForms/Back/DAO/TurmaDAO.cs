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
        public List<Turma> BuscarTurmasPorProfessor(int id)
        {
            try
            {
                List<Turma> turmas = new List<Turma>();
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT t.ID, t.Nome_Turma FROM professor_turma p JOIN turma t ON t.ID = fk_Turma_ID WHERE fk_Professor_ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID",  id);
                return ListarTurmas(cmd);
            }
            catch (Exception)
            {
                throw;
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
                    
                    int id = Convert.ToInt32(dr["ID"]);
                    string nome = dr["Nome_Turma"].ToString();
                    Turma turma = new Turma(id, nome);
                    turmas.Add(turma);
                }
                return turmas;

            }
            catch (Exception)
            {

                throw;
            }
            
            
        }

        internal Turma ReceberTurmaPorId(int idTurma)
        {
            try
            {
                Turma turma;
                int id;
                string nome;
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM turma WHERE ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID", idTurma);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    id = Convert.ToInt32(dr["ID"]);
                    nome = dr["Nome_Turma"].ToString();
                    turma = new Turma(id, nome);
                    return turma;
                }
                return null;
                               
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.FecharConexao(); }
        }
    }
}
