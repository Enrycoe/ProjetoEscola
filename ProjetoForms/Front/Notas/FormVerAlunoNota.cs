using ProjetoForms.Back.Entities;
using ProjetoForms.Back.Model;
using ProjetoForms.Front.Alunos;
using ProjetoForms.Front.Notas;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetoForms
{
    public partial class FormVerAlunoNota : Form
    {
        AlunoModel alunoModel = new AlunoModel();
        TurmaModel turmaModel = new TurmaModel();
        private Professor professor;

        public FormVerAlunoNota()
        {
            InitializeComponent();
          
        }

        public FormVerAlunoNota(Professor professor)
        {
            InitializeComponent();
           
            this.professor = professor;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormVerAlunoNota_Load(object sender, EventArgs e)
        {
            cbTurma.ValueMember = "id";
            cbTurma.DisplayMember = "Nome_Turma";
            cbTurma.DataSource = turmaModel.BuscarTurmasPorProfessor(professor);
            gridAlunos.EnableHeadersVisualStyles = false;
            gridAlunos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            PesquisarAluno();
            
        }


        private void gridAlunos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(gridAlunos.CurrentRow.Cells[0].Value);
                Aluno aluno = alunoModel.ReceberAlunoPorId(id);
                Form f = new FormCadastrarProva(aluno, professor);
                f.ShowDialog();
                PesquisarAluno();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbTurma_TextChanged(object sender, EventArgs e)
        {
            PesquisarAluno();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

            PesquisarAluno();
        }

        private void txtRA_TextChanged(object sender, EventArgs e)
        {
            PesquisarAluno();
        }

        private void PesquisarAluno()
        {
            try
            {
                int ra;
                string nome = txtNome.Text;
                string raStr = txtRA.Text;
                if (!(string.IsNullOrEmpty(raStr)))
                {
                    ra = Convert.ToInt32(raStr);
                }
                else
                {
                    ra = 0;
                }

                string turma = cbTurma.Text;
                int idTurma = Convert.ToInt32(cbTurma.SelectedValue);
                gridAlunos.AutoGenerateColumns = false;
                gridAlunos.DataSource = alunoModel.PesquisarAluno<Aluno>(nome, raStr, ra, turma, idTurma);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !Char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
