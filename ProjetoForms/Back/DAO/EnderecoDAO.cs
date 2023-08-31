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
    public class EnderecoDAO
    {

   
        private BairroDAO bairroDAO;
        private IDataBase dataBase;

        public EnderecoDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;
            bairroDAO = new BairroDAO(dataBase);
        }

        public int ReceberIDEndereco(Endereco endereco)
        {  
            try
            {
                string query = "SELECT ID FROM endereco WHERE Nome_Rua = @nome AND Numero_Casa = @numero";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nome", endereco.NomeRua },
                    {"@numero", endereco.NumCasa }
                };
                
                var result =dataBase.ExecuteScalar(query, parametros);
                
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void AtualizarEndereco(Endereco endereco, Endereco enderecoAntigo)
        {
            try
            {
                int idEndereco = ReceberIDEndereco(enderecoAntigo);
                
                string query = "UPDATE endereco SET Nome_Rua = @nome_rua, Numero_Casa = @numero_casa, fk_bairro_id = @fk_bairro_id WHERE ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nome_rua", endereco.NomeRua },
                    {"@numero_casa", endereco.NumCasa },
                    {"@fk_bairro_id", endereco.Bairro.Id},
                    {"@ID", idEndereco }
                };
                dataBase.ExecuteCommand(query, parametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CadastrarEndereco(Endereco endereco)
        {
            try
            {
                string query = "INSERT INTO endereco(Nome_Rua, Numero_Casa, fk_bairro_id) VALUES(@nome_rua, @numero_casa, @fk_bairro_id)";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nome_rua", endereco.NomeRua },
                    {"@numero_casa", endereco.NumCasa },
                    {"@fk_bairro_id", endereco.Bairro.Id},
                };
                dataBase.ExecuteCommand(query, parametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public Endereco ReceberEnderecoPorPessoa(int enderecoPessoaId)
        {
            try
            {
             
                
                string query = "SELECT * FROM endereco WHERE ID = @enderecoPessoa";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@enderecoPessoa", enderecoPessoaId }
                };

               
                List<Dictionary<string, object>> resultados = dataBase.ExecuteReader(query, parametros);
                foreach (Dictionary<string, object> linha in resultados)
                {
                    
                    int numCasa = Convert.ToInt32(linha["Numero_Casa"]);
                    string nomeRua = linha["Nome_Rua"].ToString();
                    int bairroId = Convert.ToInt32(linha["fk_bairro_id"]);
                    Bairro bairro = bairroDAO.ReceberBairroPorId(bairroId);
                    Endereco endereco = new Endereco(enderecoPessoaId, numCasa, nomeRua, bairro);
                    return endereco;
                }
 
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ReceberIDUltimoEndereco()
        {
            try
            {
                string query = $"SELECT id FROM endereco ORDER BY id DESC LIMIT 1";
                var result = dataBase.ExecuteScalar(query);
                
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
