using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoForms.Back
{
    internal class ConexaoMariaDB : IDataBase
    {
        public string conexao = "SERVER=127.0.0.1; PORT=3307; DATABASE=db_escola; USER=root; PASSWORD=123;";
        public MySqlConnection conn = null;
        public void AbrirConexao()
        {
            try
            {
                conn = new MySqlConnection(conexao);
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExecuteCommand(string query, params object[] args)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                for (int i = 0; i < args.Length; i++)
                {
                    string paramName = $"@param{i}";
                    cmd.Parameters.AddWithValue(paramName, args[i]);
                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ExecuteCommand(string query, Dictionary<string, object> args)
        {
            throw new NotImplementedException();
        }

        public void ExecuteCommand(string querry)
        {
            throw new NotImplementedException();
        }

        public List<Dictionary<string, object>> ExecuteReader(string query, object[] args, bool[] usarLike)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                for (int i = 0; i < args.Length; i++)
                {
                    string paramName = $"@param{i}";
                    cmd.Parameters.AddWithValue(paramName, args[i]);
                }
                List<Dictionary<string, object>> resultados = new List<Dictionary<string, object>>();
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Dictionary<string, object> linha = new Dictionary<string, object>();
                    for (int i = 0; i < result.FieldCount; i++)
                    {
                        string NomeColuna = result.GetName(i);
                        object valorColuna = result[1];

                        linha[NomeColuna] = valorColuna;
                    }
                    resultados.Add(linha);

                }
                cmd.Dispose();
                return resultados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Dictionary<string, object>> ExecuteReader(string query, Dictionary<string, object> args)
        {
            throw new NotImplementedException();
        }

        public List<Dictionary<string, object>> ExecuteReader(string query)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string query, params object[] args)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                for (int i = 0; i < args.Length; i++)
                {
                    string paramName = $"@param{i}";
                    cmd.Parameters.AddWithValue(paramName, args[i]);
                }
                return cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object ExecuteScalar(string query, Dictionary<string, object> args)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string querry)
        {
            throw new NotImplementedException();
        }

        public void FecharConexao()
        {
            try
            {
                conn = new MySqlConnection(conexao);
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
