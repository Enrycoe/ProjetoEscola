using ProjetoForms.Back;
using ProjetoForms.Back.Entities;
using ProjetoForms.Back.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Front
{
    public partial class FormLogin : Form
    {
        UsuarioModel usuarioModel = new UsuarioModel();
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            Usuario usuario = usuarioModel.ReceberUsuario(nome, senha);
            if (usuario.Id == 0)
            {
                MessageBox.Show("Usuario ou senha incorretas", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

           
         
            Thread starForm = new Thread(new ThreadStart(() => { new FormMain(usuario).ShowDialog(); }));   
            starForm.Start();
            this.Close();
            

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
