using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using ProjetoForms.Back;
using ProjetoForms.Back.Entities;
using ProjetoForms.Back.Model;
using ProjetoForms.Front;
using ProjetoForms.Front.Alunos;
using ProjetoForms.Front.Professores;

namespace ProjetoForms
{
    public partial class FormMain : Form
    {
        private Usuario usuario;
        private Professor professor;
        Thread threadData;
        ProfessorModel professorModel = new ProfessorModel();

        public FormMain(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            if(usuario.TipoUsuario == (int)TipoDeUsuario.PROFESSOR)
            {
                this.professor = professorModel.ReceberProfessorPorUsuarioID(usuario);
                alunosToolStripMenuItem.Enabled = false;
                professoresToolStripMenuItem.Enabled = false;
                lblNomeProfessor.Text = professor.Nome;
            }
            if (usuario.TipoUsuario == (int)TipoDeUsuario.ADMINISTRADOR)
            {
                NotaTurmasToolStripMenuItem.Enabled = false;
                CalcularMediaToolStripMenuItem.Enabled = false;
                lblNomeProfessor.Text = "Administrador";
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void MostrarDataEHora()
        {
            while (true)
            {
                lblDataHora.Invoke(new Action(() => lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
            }
        }

        private void lblDataHora_Load(object sender, EventArgs e)
        {
            threadData = new Thread(new ThreadStart(MostrarDataEHora));
            threadData.IsBackground = true;
            threadData.Start();

        }


        private void verAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormVerAlunos();
            form.ShowDialog();
        }

        private void cadastrarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormCadastrarAluno();
            form.ShowDialog();
        }

        private void NotaTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormVerAlunoNota(professor);
            form.ShowDialog();
        }

        private void CalcularMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormVerAlunoMedia(professor);
            form.ShowDialog(); 
        }

        private void boletimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(professor == null)
            {
                Form form = new FormVerAlunoBoletim();
                form.ShowDialog();
            }
            else
            {
                Form form = new FormVerAlunoBoletim(professor);
                form.ShowDialog();
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormVerProfessores();
            form.ShowDialog();
        }

        private void cadastrarProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormCadastrarProfessor();
            form.ShowDialog();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {

            Thread starForm = new Thread(new ThreadStart(() => { new FormLogin().ShowDialog(); }));
            threadData.Abort();
            starForm.Start();
            this.Close();
        }

    }
}
