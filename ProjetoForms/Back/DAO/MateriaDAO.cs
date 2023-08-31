using MySql.Data.MySqlClient;
using System.Data;
using System;
using ProjetoForms.Back.Entities;
using System.Collections.Generic;

namespace ProjetoForms.Back.Model
{
    public class MateriaDAO
    {

        
        private IDataBase dataBase;

        public MateriaDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        public List<Materia> BuscarMateria()
        {
            try
            {

                string query = "SELECT * FROM materia";
                
                return ListarMaterias(dataBase.ExecuteReader(query));
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Materia> ListarMaterias(List<Dictionary<string, object>> resposta)
        {
            try
            {
                List<Materia> materias = new List<Materia>();
                foreach (Dictionary<string, object> linha in resposta)
                {
                    string nome = linha["Nome_da_Materia"].ToString();
                    int id = Convert.ToInt32(linha["ID"]);
                    Materia materia = new Materia(id, nome);
                    materias.Add(materia);
                }
                return materias;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public List<Materia> BuscarMateriaPorProfessor(int id)
        {
            try
            {

                    
                string query = "SELECT m.ID, m.Nome_da_Materia FROM materia_professor p JOIN materia m ON m.ID = fk_Materia_ID WHERE fk_Professor_ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ID", id }
                };
                return ListarMaterias(dataBase.ExecuteReader(query, parametros));
            }
            catch (Exception)
            {

                throw;
            }
        } 
    }
}