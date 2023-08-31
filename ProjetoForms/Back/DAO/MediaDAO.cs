using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.DAO
{
    public class MediaDAO
    {
        IDataBase dataBase;

        public MediaDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;   
        }
        public void CadastrarMedia(Media media)
        {
            try
            {
                string query = "INSERT INTO media (fk_materia_ID, Valor_Media, fk_Aluno_RA, fk_Bimestre_ID) VALUES (@materia, @nota, @aluno, @bimestre)";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@materia", media.Materia.Id},
                    {"@nota", media.ValorMedia },
                    {"@aluno", media.Aluno.Id},
                    {"@bimestre", media.Bimestre.Id}
                };
                dataBase.ExecuteCommand(query, parametros);         
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeletarMediaPorAluno(int id)
        {
            try
            {
                string query = "DELETE FROM media WHERE fk_Aluno_RA = @RA";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@RA", id}
                };
                dataBase.ExecuteCommand(query, parametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void ExcluirMediaExistente(Media media)
        {
            try
            {
                
                media.Id = ReceberIDMedia(media);
                string query = "UPDATE provas SET fk_Media_ID = null WHERE fk_Media_ID = @id ";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    { "@id", media.Id },

                };
                dataBase.ExecuteCommand(query, parametros );
                query = "DELETE FROM media WHERE fk_Aluno_RA = @ra AND fk_Bimestre_ID = @bimestre AND fk_Materia_ID = @materia";
                parametros = new Dictionary<string, object>()
                {
                    { "@ra", media.Aluno.Id },
                    {"@bimestre",  media.Bimestre.Id},
                    {"@materia", media.Materia.Id },
                };
                dataBase.ExecuteCommand(query, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ReceberIDMedia(Media media)
        {
            try
            {
                string query = "SELECT ID FROM media WHERE fk_Aluno_RA = @ra AND fk_Bimestre_ID = @bimestre AND fk_Materia_ID = @materia ORDER BY ID DESC LIMIT 1";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ra",  media.Aluno.Id },
                    {"@bimestre", media.Bimestre.Id },
                    {"@materia", media.Materia.Id }
                };
                return Convert.ToInt32(dataBase.ExecuteScalar(query, parametros ));      
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ReceberIDUltimaMedia()
        {
            try
            {
                string query = "SELECT ID FROM media ORDER BY ID DESC LIMIT 1";
                return Convert.ToInt32(dataBase.ExecuteScalar(query));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double ReceberMedia(Aluno aluno, int idBimestre, int idMateria)
        {
            try
            {
                string query = "SELECT Valor_Media FROM media WHERE fk_Aluno_RA = @param0 AND fk_Bimestre_ID = @param1 AND fk_Materia_ID = @param2 ORDER BY ID DESC LIMIT 1";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@aluno", aluno.Id },
                    {"@bimestre", idBimestre },
                    {"@materia", idMateria }
                };
                var media = dataBase.ExecuteScalar(query, parametros);
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
        }

        public bool VerificarMediaExistente(Media media)
        {
            try
            {
                string query = "SELECT * FROM media WHERE fk_Aluno_RA = @ra AND fk_Bimestre_ID = @param1 AND fk_Materia_ID = @param2 ORDER BY ID DESC LIMIT 1";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ra", media.Aluno.Id },
                    {"@bimestre",  media.Bimestre.Id},
                    {"@materia", media.Materia.Id}
                };
                var mediasExistentes = dataBase.ExecuteScalar(query, parametros);
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
        }
    }
}
