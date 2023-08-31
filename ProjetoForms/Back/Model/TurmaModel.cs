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
    public class TurmaModel
    {
        TurmaDAO dao = new TurmaDAO(new ConexaoMySQL());
        public List<Turma> BuscarTurmas()
        {
            try
            {
                return dao.BuscarTurmas();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Turma> BuscarTurmasPorProfessor(Professor professor)
        {
            try
            {
                return dao.BuscarTurmasPorProfessor(professor.Id);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
