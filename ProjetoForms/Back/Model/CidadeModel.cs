using ProjetoForms.Back.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Back.Model
{
    internal class CidadeModel
    {
        CidadeDAO dao =  new CidadeDAO();
        public DataTable Listar(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Listar(id);
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
