using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.DAO
{
    internal class MediaDAO
    {
        Conection conn = new Conection();
        MySqlCommand cmd;

        internal void CadastrarMedia(Media media)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("INSERT INTO media (fk_materia_ID, Valor_Media, fk_Aluno_RA, fk_Bimestre_ID) VALUES (@materia, @nota, @aluno, @bimeste)", conn.conn);
                cmd.Parameters.AddWithValue("@materia", media.Materia.Id);
                cmd.Parameters.AddWithValue("@nota", media.ValorMedia);
                cmd.Parameters.AddWithValue("@aluno", media.Aluno.Id);
                cmd.Parameters.AddWithValue("@bimeste", media.Bimestre.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao(); }
        }

        internal int ReceberIDUltimaMedia()
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT ID FROM media ORDER BY ID DESC LIMIT 1", conn.conn);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao() ;}
        }

        internal double ReceberMedia(Aluno aluno, int idBimestre, int idMateria)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT Valor_Media FROM media WHERE fk_Aluno_RA = @aluno AND fk_Bimestre_ID = @bimestre AND fk_Materia_ID = @materia ORDER BY ID DESC LIMIT 1", conn.conn);
                cmd.Parameters.AddWithValue("@aluno", aluno.Id);
                cmd.Parameters.AddWithValue("@bimestre", idBimestre);
                cmd.Parameters.AddWithValue("@materia", idMateria);
                var media = cmd.ExecuteScalar();
                if(media == null) 
                {
                    return -1;
                }
               
                return Convert.ToDouble(media);
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.FecharConexao(); }
        }

       
    }
}
