using ProjetoForms.Back.DAO;
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
    internal class EstadoModel
    {
        EstadoDAO dao = new EstadoDAO();
        public List<Estado> BuscarEstados()
        {
            try
            {
                return dao.BuscarEstados();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
