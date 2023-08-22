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
    internal class CidadeModel
    {
        CidadeDAO dao =  new CidadeDAO();
        public List<Cidade> BuscarCidadePorEstado(int id)
        {
            try
            {
                return dao.BuscarCidadePorEstado(id);
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
