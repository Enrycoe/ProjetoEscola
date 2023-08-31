using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.DAO
{
    public class TurmaDAO
    {
        private IDataBase dataBase;

        public TurmaDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        public List<Turma> BuscarTurmas()
        {
            try
            {
                string query = "SELECT * FROM turma";
                return ListarTurmas(dataBase.ExecuteReader(query));
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public List<Turma> BuscarTurmasPorProfessor(int id)
        {
            try
            {

                string query = "SELECT t.ID, t.Nome_Turma FROM professor_turma p JOIN turma t ON t.ID = fk_Turma_ID WHERE fk_Professor_ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ID",  id }
                };
               
                return ListarTurmas(dataBase.ExecuteReader(query, parametros));
            }
            catch (Exception)
            {
                throw;
            }
        }
        private List<Turma> ListarTurmas(List<Dictionary<string, object>> resposta)
        {
            try
            {
                List<Turma> turmas = new List<Turma>();
                foreach (Dictionary<string, object> linha in resposta)
                {

                    int id = Convert.ToInt32(linha["ID"]);
                    string nome = linha["Nome_Turma"].ToString();
                    Turma turma = new Turma(id, nome);
                    turmas.Add(turma);
                }
                return turmas;

            }
            catch (Exception)
            {

                throw;
            }
            
            
        }

        public Turma ReceberTurmaPorId(int idTurma)
        {
            try
            {
                Turma turma;
                int id;
                string nome;
               
                string query = "SELECT * FROM turma WHERE ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ID", idTurma},
                };
                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(query, parametros);
                foreach (Dictionary<string, object> linha in resultados)
                {
                    id = Convert.ToInt32(linha["ID"]);
                    nome = linha["Nome_Turma"].ToString();
                    turma = new Turma(id, nome);
                    return turma;
                }
                return null;
                               
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
