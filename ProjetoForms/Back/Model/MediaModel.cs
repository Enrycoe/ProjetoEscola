using ProjetoForms.Back.DAO;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Model
{
    internal class MediaModel
    {
        MediaDAO dao = new MediaDAO();
        internal void CadastrarMedia(Media media)
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

        internal void ExcluirMediaExistente(Media media)
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

        internal int ReceberIDUltimaMedia()
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

        internal double ReceberMedia(Aluno aluno, int idBimestre, int idMateria)
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

        internal bool VerificarMediaExistente(Media media)
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
