using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProjetoForms.Back.DAO
{
    public class BairroDAO
    {

       
        private CidadeDAO cidadeDAO;
        private IDataBase dataBase;

        public BairroDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;
            cidadeDAO = new CidadeDAO(dataBase);
        }

        public bool VerificarSeBairroExiste(Bairro bairro)
        {
            try
            {
                string querry = "SELECT * FROM bairro WHERE nome_bairro = @param0 AND fk_cidade_id = @param1";
               
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nomeBairro", bairro.NomeBairro },
                    {"@cidadeId",  bairro.Cidade.Id}
                };
                bool[] usarLike = { false, false };
                var result = dataBase.ExecuteScalar(querry, parametros);
                if (result != null && result != DBNull.Value)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CadastrarBairro(Bairro bairro)
        {
            try
            {
                string querry = "INSERT INTO bairro (Nome_Bairro, fk_cidade_id) VALUES (@Nome_Bairro, @fkCidade)";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@Nome_Bairro", bairro.NomeBairro },
                    {"@fkCidade",  bairro.Cidade.Id}       
                };
                dataBase.ExecuteCommand(querry, parametros); 
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Bairro ReceberBairroPorId(int id)
        {
            try
            {

                
                string querry = "SELECT * FROM bairro WHERE ID = @id";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@id", id }
                };
                List<Dictionary<string, object>> resultado =  dataBase.ExecuteReader(querry,parametros);
                
                foreach (Dictionary<string, object> linha in resultado)
                {
                    string nomeBairro = linha["Nome_Bairro"].ToString();
                    int idCidade = Convert.ToInt32(linha["fk_cidade_id"]);
                    Cidade cidade = cidadeDAO.ReceberCidadePorId(idCidade);
                    Bairro bairro = new Bairro(id, nomeBairro, cidade);
                    return bairro;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ReceberIdBairro(Bairro bairro)
        {
            try
            {
                string querry = "SELECT id FROM bairro where nome_bairro = @nomeBairro AND fk_cidade_id = @param1";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nomeBairro", bairro.NomeBairro },
                    {"@cidadeId",  bairro.Cidade.Id}
                };
                var result = dataBase.ExecuteScalar(querry, parametros);
               
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ReceberIdUltimoBairro()
        {
            try
            {
                string querry = $"SELECT id FROM bairro ORDER BY id DESC LIMIT 1";
                
                var result = dataBase.ExecuteScalar(querry);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
