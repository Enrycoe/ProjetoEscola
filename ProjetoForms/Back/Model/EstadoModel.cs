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
    public class EstadoModel
    {
        private EstadoDAO dao;
        public EstadoModel()
        {
            dao = new EstadoDAO(new ConexaoMySQL());
        }
        
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
