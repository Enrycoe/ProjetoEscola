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

        int id;
        Professor professor;
        string nomeUsuario;
        string senhaUsuario;
        int tipoUsuario;

        public Usuario()
        {
        }

        public Usuario(int id, string nomeUsuario, string senhaUsuario, int tipoUsuario, Professor professor)
        {
            this.id = id;
            this.nomeUsuario = nomeUsuario;
            this.senhaUsuario = senhaUsuario;
            this.tipoUsuario = tipoUsuario;
            this.professor = professor;
        }

        public int Id { get => id; set => id = value; }
        public Professor Professor { get => professor; set => professor = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string SenhaUsuario { get => senhaUsuario; set => senhaUsuario = value; }
        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

       
    }
}
