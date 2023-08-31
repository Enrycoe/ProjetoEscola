using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoForms.Back
{
    public class ConexaoMySQL : IDataBase
    {
        public string conexao = "SERVER=localhost; DATABASE=db_escola; USER=root; PASSWORD=Enrycoe23042003@;";
        public MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=db_escola; USER=root; PASSWORD=Enrycoe23042003@;");


       

        public void AbrirConexao()
        {
            try
            {
                conn.Open();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parametros)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                foreach (KeyValuePair<string, object> obj in parametros)
                {
                    string paramName = obj.Key.ToString();
                    cmd.Parameters.AddWithValue(paramName, obj.Value);

                }
                return cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }


        }

        public object ExecuteScalar(string querry)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(querry, conn);
               
                return cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }
        public void ExecuteCommand(string query, Dictionary<string, object> parametros)
        {
            try
             {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                foreach (KeyValuePair<string, object> obj in parametros)
                {
                    string paramName = obj.Key.ToString();
                    cmd.Parameters.AddWithValue(paramName, obj.Value);

                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

        }
        

        public List<Dictionary<string, object>> ExecuteReader(string query, Dictionary<string, object> parametros)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                foreach (KeyValuePair<string, object> obj in parametros)
                {
                    string paramName = obj.Key.ToString();
                    cmd.Parameters.AddWithValue(paramName, obj.Value);
                   
                }
                List<Dictionary<string, object>> resultados = new List<Dictionary<string, object>>();

                
                
                var result = cmd.ExecuteReader();
                
                while (result.Read())
                {
                    Dictionary<string, object> linha = new Dictionary<string, object>();
                    Parallel.For(0, result.FieldCount, index =>
                    {
                        string NomeColuna = result.GetName(index);
                        object valorColuna = result[index];

                        linha[NomeColuna] = valorColuna;
                    });
                   
                    resultados.Add(linha);
                    
                }
                
                return resultados;
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public void FecharConexao()
        {
            try
            {
                conn = new MySqlConnection(conexao);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

      

        public void ExecuteCommand(string querry)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(querry, conn);
               
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public List<Dictionary<string, object>> ExecuteReader(string query)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
               
                List<Dictionary<string, object>> resultados = new List<Dictionary<string, object>>();


                
                var result = cmd.ExecuteReader();
                
                while (result.Read())
                {
                    Dictionary<string, object> linha = new Dictionary<string, object>();
                    for (int i = 0; i < result.FieldCount; i++)
                    {
                        string NomeColuna = result.GetName(i);
                        object valorColuna = result[i];

                        linha[NomeColuna] = valorColuna;
                    };

                    resultados.Add(linha);
                }

                return resultados;
            }
            catch (Exception)
            {

                throw;  
            }
            finally { conn.Close(); }
        }

       
    }
}

