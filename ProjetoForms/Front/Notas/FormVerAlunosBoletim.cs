using ProjetoForms.Back.Entities;
using ProjetoForms.Back.Model;
using ProjetoForms.Front.Alunos;
using ProjetoForms.Front.Notas;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoForms
{
    public partial class FormVerAlunoBoletim : Form
    {
        AlunoModel AlunoModel = new AlunoModel();
        TurmaModel turmaModel = new TurmaModel();
        
        public FormVerAlunoBoletim()
        {
            InitializeComponent();
            cbTurma.ValueMember = "id";
            cbTurma.DisplayMember = "Nome_Turma";
        }

        private void FormVerAlunoBoletim_Load(object sender, EventArgs e)
        {
            cbTurma.DataSource = turmaModel.Listar();
            cbTurma.SelectedIndex = 12;
            Listar();
        }

        public void Listar()
        {
            try
            {
                gridAlunos.DataSource = AlunoModel.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados: " + ex.Message);
            }
        }

        private void gridAlunos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();
                aluno.Id = Convert.ToInt32(gridAlunos.CurrentRow.Cells[1].Value);
                Form f = new FormBoletim(aluno);
                f.ShowDialog();
            }
            catch (System.InvalidCastException)
            {

            }
        }

        private void cbTurma_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void txtRA_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            if ((txtNome.Text == "") && (txtRA.Text == "") && (cbTurma.Text == ""))
            {
                Listar();
                return;
            }

            if (!(txtNome.Text == "") && !(txtRA.Text == "") && !(cbTurma.Text == ""))
            {
                string nome = txtNome.Text;
                int RA = Convert.ToInt32(txtRA.Text);
                int idTurma = Convert.ToInt32(cbTurma.SelectedValue);
                gridAlunos.DataSource = BuscarAluno(nome, RA, idTurma);
                return;
            }
            if (!(txtNome.Text == "") && (txtRA.Text == "") && (cbTurma.Text == ""))
            {
                string nome = txtNome.Text;
                gridAlunos.DataSource = BuscarAlunoPorNome(nome);
                return;
            }
            if (!(txtNome.Text == "") && !(txtRA.Text == "") && (cbTurma.Text == ""))
            {
                string nome = txtNome.Text;
                int RA = Convert.ToInt32(txtRA.Text);
                gridAlunos.DataSource = BuscarAlunoPorNomeERA(nome, RA);
                return;
            }
            if (!(txtNome.Text == "") && (txtRA.Text == "") && !(cbTurma.Text == ""))
            {
                string nome = txtNome.Text;
                int idTurma = Convert.ToInt32(cbTurma.SelectedValue);
                gridAlunos.DataSource = BuscarAlunoPorNomeETurma(nome, idTurma);
                return;
            }
            if ((txtNome.Text == "") && !(txtRA.Text == "") && (cbTurma.Text == ""))
            {
                int RA = Convert.ToInt32(txtRA.Text);
                gridAlunos.DataSource = BuscarAlunoPorRA(RA);
                return;
            }

            if ((txtNome.Text == "") && !(txtRA.Text == "") && !(cbTurma.Text == ""))
            {
                int RA = Convert.ToInt32(txtRA.Text);
                int idTurma = Convert.ToInt32(cbTurma.SelectedValue);
                gridAlunos.DataSource = BuscarAlunoPorRAETurma(RA, idTurma);
                return;
            }

            if ((txtNome.Text == "") && (txtRA.Text == "") && !(cbTurma.Text == ""))
            {
                int idTurma = Convert.ToInt32(cbTurma.SelectedValue);
                gridAlunos.DataSource = BuscarAlunoPorTurma(idTurma);
                return;
            }

        }

        private DataTable BuscarAluno(string nome, int rA, int idTurma)
        {
            return AlunoModel.BuscarAluno(nome, rA, idTurma);
        }

        private DataTable BuscarAlunoPorNome(string nome)
        {
            return AlunoModel.BuscarAlunoPorNome(nome);
        }
        private DataTable BuscarAlunoPorNomeERA(string nome, int rA)
        {
            return AlunoModel.BuscarAlunoPorNomeERA(nome, rA);
        }

        private DataTable BuscarAlunoPorNomeETurma(string nome, int idTurma)
        {
            return AlunoModel.BuscarAlunoPorNomeETurma(nome, idTurma);
        }
        private DataTable BuscarAlunoPorRA(int rA)
        {
            return AlunoModel.BuscarAlunoPorRA(rA);
        }
        private object BuscarAlunoPorRAETurma(int rA, int idTurma)
        {
            return AlunoModel.BuscarAlunoPorRAETurma(rA, idTurma);
        }

        private object BuscarAlunoPorTurma(int idTurma)
        {
            return AlunoModel.BuscarAlunoPorTurma(idTurma);
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
    }
}
