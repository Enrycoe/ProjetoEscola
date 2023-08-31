using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoForms.Back.Entities
{
    public class Usuario 
    {

        private int id;
        private string nomeUsuario;
        private string senhaUsuario;
        private int tipoUsuario;

        public Usuario()
        {
        }

        public Usuario(int id, string nomeUsuario, string senhaUsuario, int tipoUsuario)
        {
            this.id = id;
            this.nomeUsuario = nomeUsuario;
            this.senhaUsuario = senhaUsuario;
            this.tipoUsuario = tipoUsuario;
        }

        public int Id { get => id; set => id = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string SenhaUsuario { get => senhaUsuario; set => senhaUsuario = value; }
        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

       
    }
}
