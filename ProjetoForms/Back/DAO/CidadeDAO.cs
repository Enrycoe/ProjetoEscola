using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Back.DAO
{
    public class CidadeDAO 
    {
        private IDataBase dataBase;
        private EstadoDAO estadoDAO;

        public CidadeDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;
            this.estadoDAO = new EstadoDAO(dataBase);
        }

        public List<Cidade> BuscarCidadePorEstado(int id)
        {
            try
            {
                
               
                string query = "SELECT * FROM cidade WHERE fk_estado_ID = @id";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@id", id }
                };
                var resultados = dataBase.ExecuteReader(query, parametros);
                return ListarCidades(resultados);
               
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public Cidade ReceberCidadePorId(int idCidade)
        {
            try
            {
                
               
                string query = "SELECT * FROM cidade WHERE ID = @idCidade";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@idCidade", idCidade }
                };
                
                List<Dictionary<string, object>> resultado = dataBase.ExecuteReader(query, parametros);
                foreach (Dictionary<string, object> linha in resultado)
                {
                    
                    string nome = linha["Nome_Cidade"].ToString();
                    int idEstado = Convert.ToInt32(linha["fk_Estado_ID"]);
                    Estado estado = estadoDAO.ReceberEstadoPorId(idEstado);
                    Cidade cidade = new Cidade(idCidade, nome, estado);
                    return cidade;
                }
            
                return null;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private List<Cidade> ListarCidades (List<Dictionary<string, object>> resposta)
        {
            try
            {
                List<Cidade> cidades = new List<Cidade>();
                foreach (Dictionary<string, object> linha in resposta)
                {
                    int idCidade = Convert.ToInt32(linha["ID"]);
                    string nome = linha["Nome_Cidade"].ToString();
                    int idEstado = Convert.ToInt32(linha["fk_Estado_ID"]);
                    Estado estado = estadoDAO.ReceberEstadoPorId(idEstado);
                    Cidade cidade = new Cidade(idCidade, nome, estado);
                    cidades.Add(cidade);    
                }

                return cidades;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
      
    }
}
