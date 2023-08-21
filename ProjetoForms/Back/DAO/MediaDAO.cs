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
        ConexaoMySQL conn = new ConexaoMySQL();
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
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal void DeletarMediaPorAluno(int id)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("DELETE FROM media WHERE fk_Aluno_RA = @RA", conn.conn);
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

        internal void ExcluirMediaExistente(Media media)
        {
            try
            {
                
                conn.AbrirConexao();
                media.Id = ReceberIDMedia(media);
                cmd.Dispose();
                cmd = new MySqlCommand("UPDATE provas SET fk_Media_ID = null WHERE fk_Media_ID = @media ", conn.conn);
                cmd.Parameters.AddWithValue("@media", media.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = new MySqlCommand("DELETE FROM media WHERE fk_Aluno_RA = @aluno AND fk_Bimestre_ID = @bimestre AND fk_Materia_ID = @materia", conn.conn);
                cmd.Parameters.AddWithValue("@aluno", media.Aluno.Id);
                cmd.Parameters.AddWithValue("@bimestre", media.Bimestre.Id);
                cmd.Parameters.AddWithValue("@materia", media.Materia.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();  
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal int ReceberIDMedia(Media media)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT ID FROM media WHERE fk_Aluno_RA = @aluno AND fk_Bimestre_ID = @bimestre AND fk_Materia_ID = @materia ORDER BY ID DESC LIMIT 1", conn.conn);
                cmd.Parameters.AddWithValue("@aluno", media.Aluno.Id);
                cmd.Parameters.AddWithValue("@bimestre", media.Bimestre.Id);
                cmd.Parameters.AddWithValue("@materia", media.Materia.Id);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
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
            catch (Exception ex)
            {

                throw ex;
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
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }

        internal bool VerificarMediaExistente(Media media)
        {
            try
            {
                conn.AbrirConexao();
                cmd = new MySqlCommand("SELECT * FROM media WHERE fk_Aluno_RA = @aluno AND fk_Bimestre_ID = @bimestre AND fk_Materia_ID = @materia ORDER BY ID DESC LIMIT 1", conn.conn);
                cmd.Parameters.AddWithValue("@aluno", media.Aluno.Id);
                cmd.Parameters.AddWithValue("@bimestre", media.Bimestre.Id);
                cmd.Parameters.AddWithValue("@materia", media.Materia.Id);
                var mediasExistentes = cmd.ExecuteScalar();
                if (mediasExistentes != null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.FecharConexao(); }
        }
    }
}
