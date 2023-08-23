using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Usuario : IUsuario
    {
        ConexaoMySQL Conn = new ConexaoMySQL();
        MySqlCommand cmd;

        int id;
        Professor professor;
        string nomeUsuario;
        string senhaUsuario;
        int tipoUsuario;

        public int Id { get => id; set => id = value; }
        public Professor Professor { get => professor; set => professor = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string SenhaUsuario { get => senhaUsuario; set => senhaUsuario = value; }
        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        public virtual void Logar(Usuario usuario, string senha)
        {
            try
            {
                Conn.AbrirConexao();

                cmd = new MySqlCommand("SELECT Senha FROM usuario WHERE ID = @ID", Conn.conn);
                cmd.Parameters.AddWithValue("@ID", usuario.Id);
                var senhaBD = cmd.ExecuteScalar();
                if (senha == senhaBD.ToString())
                {

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
