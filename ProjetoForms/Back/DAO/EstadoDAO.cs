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
    public class EstadoDAO
    {
        private IDataBase dataBase;

        public EstadoDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        public List<Estado> BuscarEstados()
        {
            try
            {
                
                
                string query = "SELECT * FROM estado";
                List<Dictionary<string, object>> resultado = dataBase.ExecuteReader(query);
               
                return ListarEstados(resultado);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public Estado ReceberEstadoPorId(int idEstado)
        {
            try
            {
               
                string query = "SELECT * FROM estado WHERE ID = @idEstado";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    { "idEstado", idEstado }
                };
                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(query, parametros);
                foreach (Dictionary<string, object> linha  in resultados)
                {
                    
                    
                    string nome = linha["Nome_Estado"].ToString();
                    string sigla = linha["Sigla"].ToString();
                    Estado estado = new Estado(idEstado, nome, sigla);
                    return estado;
                }
                
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<Estado> ListarEstados(List<Dictionary<string, object>> resposta)
        {
            try
            {
                List<Estado> estados = new List<Estado>();
                
                foreach (Dictionary<string, object> linha in resposta)
                {
                    
                    string nome = linha["Nome_Estado"].ToString();
                    int id = Convert.ToInt32(linha["ID"]);
                    string sigla = linha["Sigla"].ToString();
                    Estado estado = new Estado(id, nome, sigla);
                    estados.Add(estado);
                }

                return estados;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
