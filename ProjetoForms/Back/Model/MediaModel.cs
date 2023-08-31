using ProjetoForms.Back.DAO;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Model
{
    public class MediaModel
    {
        MediaDAO dao = new MediaDAO(new ConexaoMySQL());
        public void CadastrarMedia(Media media)
        {
            try
            {
                dao.CadastrarMedia(media);
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
                dao.ExcluirMediaExistente(media);
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
                return dao.ReceberIDUltimaMedia();
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
                return dao.ReceberMedia(aluno, idBimestre, idMateria);
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
                return dao.VerificarMediaExistente(media);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
