using MySql.Data.MySqlClient;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProjetoForms.Back.DAO
{
    public class UsuarioDAO
    {
        IDataBase dataBase;
        public UsuarioDAO(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }


        public int GerarERetornarLogin(string nome)
        {
            try
            {
                
                string query = "INSERT INTO usuario (Usuario, Senha, fk_Tipo_Usuario) VALUES (@nome, 123, 2)";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@nome", nome }
                };
                dataBase.ExecuteCommand(query, parametros);
                return RetornarIDUltimoUsuario();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int RetornarIDUltimoUsuario()
        {
            try
            {
                
                string query = $"SELECT id FROM usuario ORDER BY id DESC LIMIT 1";
                return Convert.ToInt32(dataBase.ExecuteScalar(query));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Usuario ReceberUsuario(string nome, string senha)
        {
            try
            {
                ProfessorDAO professorDAO = new ProfessorDAO(new ConexaoMySQL());
                string query = "SELECT * FROM usuario u WHERE Usuario = @usuario AND Senha = @senha" ;
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@usuario", nome },
                    {"@senha", senha }
                };
               var resultados = dataBase.ExecuteReader(query, parametros);
                foreach (Dictionary<string, object> linha in resultados)
                {

                    string nomeUsuario = linha["Usuario"].ToString();
                    string senhaUsuario = linha["Senha"].ToString();
                    int tipoUsuario = Convert.ToInt32(linha["fk_Tipo_Usuario"]);
                    int id = Convert.ToInt32(linha["ID"]);
                    Usuario usuario = new Usuario(id, nomeUsuario, senhaUsuario, tipoUsuario);
                    return usuario;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario ReceberUsuarioPorProfessor(Professor professor)
        {
            try
            {
                
                string query = "SELECT * FROM usuario u JOIN professor p ON p.fk_Usuario_ID = u.ID WHERE p.ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ID", professor.Id }
                };

                var resultados = dataBase.ExecuteReader(query, parametros);
                foreach (Dictionary<string, object> linha in resultados)
                {
                    string nomeUsuario = linha["Usuario"].ToString();             
                    string senhaUsuario = linha["Senha"].ToString();
                    int tipoUsuario = Convert.ToInt32(linha["fk_Tipo_Usuario"]);
                    int id = Convert.ToInt32(linha["ID"]);
                    Usuario usuario = new Usuario(id, nomeUsuario, senhaUsuario, tipoUsuario);
                    return usuario;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool VerificarSeLoginExiste(string login)
        {
            try
            {
               string query = "SELECT Usuario FROM usuario WHERE Usuario = @login";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@login", login }
                };
               
                var result = dataBase.ExecuteScalar(query,parametros);
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool VerificarSeTrocouASenha(string senha, string login)
        {
            try
            {
                string query = "SELECT Senha FROM usuario WHERE Usuario = @login AND Senha = @senha";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@senha", senha },
                    {"@login", login }
                };
                
                var result = dataBase.ExecuteScalar(query, parametros);
                if (result != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }

        public void DeletarLoginPorUsuario(Usuario usuario)
        {
            try
            {


                string query = "DELETE FROM usuario WHERE ID = @ID";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@ID", usuario.Id }
                };
                dataBase.ExecuteCommand(query, parametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void AlterarSenha(string senha, string login)
        {
            try
            {
                string query = "UPDATE usuario SET Senha = @senha WHERE Usuario = @login";
                Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"@senha", senha },
                    {"@login", login }
                };
                dataBase.ExecuteCommand(query, parametros);

            }
            catch (Exception ex)
            {

                throw ex;
            }

           
        }
    }
}
