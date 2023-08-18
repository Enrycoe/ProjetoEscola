using MySql.Data.MySqlClient;
using System.Data;
using System;
using ProjetoForms.Back.Entities;

namespace ProjetoForms.Back.Model
{
    internal class MateriaDAO
    {

        Conection conn = new Conection();
        MySqlCommand cmd;
        public DataTable Listar()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM materia", conn.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

     
    }
}