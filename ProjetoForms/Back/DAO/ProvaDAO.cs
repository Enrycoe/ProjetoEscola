using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.DAO
{
    internal class ProvaDAO
    {
        ConexaoMySQL conn = new ConexaoMySQL();
        MySqlCommand cmd;
        public List<Prova> BuscarProvaPorMateria(Prova prova)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM provas WHERE fk_Materia_ID = @materia AND fk_Aluno_RA = @aluno", conn.conn);
                cmd.Parameters.AddWithValue("@materia", prova.Materia.Id);
                cmd.Parameters.AddWithValue("@aluno", prova.Aluno.Id);
                return ListarProva(cmd);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }

        }

        public List<Prova> ListarProva(MySqlCommand cmd)
        {
            try
            {
                List<Prova> provas = new List<Prova>();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    var prova = new Prova();
                    prova.Aluno = new Aluno();
                    prova.Materia = new Materia();
                    prova.Media = new Media();  
                    prova.Nota = Convert.ToDouble(dr["nota"]);
                    prova.Id = Convert.ToInt32(dr["id"]);
                    prova.Descricao = dr["descricao"].ToString();
                    prova.Materia.Id = Convert.ToInt32(dr["fk_Materia_ID"]);   
                    prova.Aluno.Id = Convert.ToInt32(dr["fk_Aluno_RA"]);
                    prova.Media.Id = Convert.ToInt32(dr["fk_Media_RA"]);
                    provas.Add(prova);
                }
                return provas;
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void CadastrarProva(Prova prova, Aluno aluno)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("INSERT INTO provas (nota, descricao, fk_materia_ID, fk_Aluno_RA) VALUES (@nota, @descricao, @materia, @aluno)", conn.conn);
                cmd.Parameters.AddWithValue("@nota", prova.Nota);
                cmd.Parameters.AddWithValue("@descricao", prova.Descricao);
                cmd.Parameters.AddWithValue("@materia", prova.Materia.Id);
                cmd.Parameters.AddWithValue("@aluno", aluno.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal void DeletarProvaPorAluno(int id)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("DELETE FROM provas WHERE fk_Aluno_RA = @RA", conn.conn);
                cmd.Parameters.AddWithValue("@RA", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
            
        }

        internal void DesignarProvaMedia(Prova prova)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("UPDATE provas SET fk_media_ID = @media WHERE ID = @ID", conn.conn);
                cmd.Parameters.AddWithValue("@ID", prova.Id);
                cmd.Parameters.AddWithValue("@media", prova.Media.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }
    }
}
