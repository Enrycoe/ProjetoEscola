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
    public class BimestreDAO 
    {
        IDataBase dataBase;
        public BimestreDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }
        public List<Bimestre> BuscarBimestres()
        {
            try
            {
                

                string query = "SELECT * FROM bimestre";
                return ListarBimestres(dataBase.ExecuteReader(query));
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Bimestre> ListarBimestres(List<Dictionary<string, object>> resposta)
        {
            try
            {
                List<Bimestre> bimestres = new List<Bimestre>();
                foreach (Dictionary<string, object> linha in resposta)
                {

                    string nome = linha["bimestre"].ToString();
                    int id = Convert.ToInt32(linha["id"]);
                    Bimestre bimestre = new Bimestre(id, nome);
                    bimestres.Add(bimestre);
                }
                return bimestres;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
