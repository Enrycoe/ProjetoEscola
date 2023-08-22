using MySql.Data.MySqlClient;
using System.Data;
using System;
using ProjetoForms.Back.Entities;
using System.Collections.Generic;

namespace ProjetoForms.Back.Model
{
    internal class MateriaDAO
    {

        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;
        public List<Materia> BuscarMateria()
        {
            try
            {
                
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM materia", conn.conn);
                
                return ListarMaterias(cmd);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        private List<Materia> ListarMaterias(MySqlCommand cmd)
        {
            try
            {
                List<Materia> materias = new List<Materia>();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    var materia = new Materia();
                    materia.NomeMateria = dr["Nome_da_Materia"].ToString();
                    materia.Id = Convert.ToInt32(dr["ID"]);
                    materias.Add(materia);
                }
                return materias;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public List<Materia> BuscarMateriaPorProfessor(Professor professor)
        {
            try
            {
                List<Materia> materias = new List<Materia>();
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT m.ID, m.Nome_da_Materia FROM materia_professor p JOIN materia m ON m.ID = fk_Materia_ID WHERE fk_Professor_ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID", professor.Id);
                return ListarMaterias(cmd);
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao(); };
        } 
    }
}