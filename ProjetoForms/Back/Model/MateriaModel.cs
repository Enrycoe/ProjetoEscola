using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Back.Model
{
    internal class MateriaModel
    {
        MateriaDAO dao = new MateriaDAO();
        public DataTable Listar()
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
