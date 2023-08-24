using ProjetoForms.Back.DAO;
using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Model
{
    internal class UsuarioModel
    {
        UsuarioDAO dao = new UsuarioDAO();

        internal int GerarERetornarLogin()
        {
            try
            {
                string nome = GerarNomeLogin();
                return dao.GerarERetornarLogin(nome);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GerarNomeLogin()
        {
            char[] chars = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            var random = new Random();
            int numeroSorteado = random.Next(chars.Length);
            char letra = chars[numeroSorteado];
            string numeros = random.Next(1000, 9999).ToString();
            string login = letra + numeros;
            bool loginExiste = dao.VerificarSeLoginExiste(login);
            if (loginExiste)
            {
                return GerarNomeLogin();
            }
            else
            {
                return login;
            }
        }

        internal Usuario ReceberUsuario(string nome, string senha)
        {
            try
            {
                return dao.ReceberUsuario(nome, senha);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal Usuario ReceberUsuarioPorProfessor(Professor professor)
        {
            try
            {
                return dao.ReceberUsuarioPorProfessor(professor);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal bool VerificarSeTrocouASenha(string senha, string login)
        {
            try
            {
                return dao.VerificarSeTrocouASenha(senha, login);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void AlterarSenha(string senha, string login)
        {
            try
            {
                dao.AlterarSenha(senha, login);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
