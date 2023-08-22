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
                    materia.Id = Convert.ToInt32(dr["id"]);
                    materias.Add(materia);
                }
                return materias;
            }
            catch (Exception)
            {

                throw;
            }
        }

     
    }
}