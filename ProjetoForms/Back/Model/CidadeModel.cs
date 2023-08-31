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
    public class CidadeModel
    {
        private CidadeDAO dao;
        public CidadeModel()
        {
            dao = new CidadeDAO(new ConexaoMySQL());
        }
        
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
