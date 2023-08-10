using ProjetoForms.Back.DAO;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Model
{
    internal class BimestreModel
    {
        BimestreDAO dao = new BimestreDAO();

        internal object Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Listar();
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
