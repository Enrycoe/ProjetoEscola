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
    public class BimestreModel
    {
        BimestreDAO dao = new BimestreDAO();

        public List<Bimestre> BuscarBimestres()
        {
            try
            {
                return dao.BuscarBimestres();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
