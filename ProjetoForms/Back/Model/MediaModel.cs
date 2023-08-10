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
            catch (Exception)
            {

                throw;
            }
        }

        internal int ReceberIDUltimaMedia()
        {
            try
            {
                return dao.ReceberIDUltimaMedia();
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal double ReceberMedia(Aluno aluno, int idBimestre, int idMateria)
        {
            return dao.ReceberMedia(aluno, idBimestre, idMateria);
        }

  
    }
}
