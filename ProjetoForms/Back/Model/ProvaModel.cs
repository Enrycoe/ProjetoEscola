using ProjetoForms.Back.DAO;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Back.Model
{
    public class ProvaModel
    {
        ProvaDAO dao = new ProvaDAO(new ConexaoMySQL());

        public void DesignarProvaMedia(Prova prova)
        {
            try
            {
               dao.DesignarProvaMedia(prova);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Prova> BuscarProvaPorMateria(Prova prova)
        {
            try
            {
                return dao.BuscarProvaPorMateria(prova);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void CadastrarProva(Prova prova)
        {

            try
            {
                dao.CadastrarProva(prova);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
