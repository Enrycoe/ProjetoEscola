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
    public class MateriaModel
    {
        MateriaDAO dao = new MateriaDAO(new ConexaoMySQL());
        public List<Materia> BuscarMateria()
        {

            try
            {
               return dao.BuscarMateria();             
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Materia> BuscarMateriaPorProfessor(Professor professor)
        {

            try
            {
                return dao.BuscarMateriaPorProfessor(professor.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
