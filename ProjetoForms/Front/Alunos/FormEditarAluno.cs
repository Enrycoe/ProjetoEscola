using ProjetoForms.Back.Entities;
using ProjetoForms.Back.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Front.Alunos
{
    public partial class FormEditarAluno : Form
    {
        int id;
        AlunoModel alunoModel = new AlunoModel();
        CidadeModel cidadeModel = new CidadeModel();
        EstadoModel estadoModel = new EstadoModel();
        TurmaModel turmaModel = new TurmaModel();
        int x = 0;
        int y = 0;
        public FormEditarAluno(Aluno aluno)
        {
            InitializeComponent();
            id = aluno.Id;
            cbEstado.ValueMember = "id";
            cbEstado.DisplayMember = "Sigla";
            cbCidade.ValueMember = "id";
            cbCidade.DisplayMember = "Nome_Cidade";
            cbTurma.ValueMember = "id";
            cbTurma.DisplayMember = "Nome_Turma";
        }

        private void FormEditarAluno_Load(object sender, EventArgs e)
        {

            txtRA.Text = id.ToString();
            cbEstado.DataSource = estadoModel.Listar();
            cbTurma.DataSource = turmaModel.Listar();
            Aluno aluno = alunoModel.ReceberAluno(id);
            cbEstado.SelectedValue = aluno.Endereco.Bairro.Cidade.Estado.Id;
            cbCidade.SelectedValue = aluno.Endereco.Bairro.Cidade.Id;
            cbTurma.SelectedValue = aluno.Turma.Id;
            txtNomeCompleto.Text = aluno.Nome;
            txtBairro.Text = aluno.Endereco.Bairro.Nome_bairro;
            dtNascimento.Text = aluno.DataNascimento.ToString();
            txtRua.Text = aluno.Endereco.NomeRua;
            txtNumeroCasa.Text = aluno.Endereco.NumCasa.ToString();
            txtTelefonePessoal.Text = aluno.TelefonePessoal;
            txtTelefoneFixo.Text = aluno.TelefoneFixo;
            txtTelefoneResponsavel.Text = aluno.TelefoneResponsavel;
            txtTelefoneResponsavel2.Text = aluno.TelefoneResponsavel2;
        }

        private void cbEstado_TextChanged(object sender, EventArgs e)
        {
            cbCidade.Text = "";

            DataTable cidadePorEstado = cidadeModel.Listar(Convert.ToInt32(cbEstado.SelectedValue));

            cbCidade.DataSource = cidadePorEstado;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Turma = new Turma();
            aluno.Endereco = new Endereco();
            aluno.Endereco.Bairro = new Bairro();
            aluno.Endereco.Bairro.Cidade = new Cidade();
            AtualizarAluno(aluno);
            this.Close();
        }

        private void AtualizarAluno(Aluno aluno)
        {

            try
            {
                Aluno alunoAntigo = alunoModel.ReceberAluno(id);

                aluno.Id = Convert.ToInt32(txtRA.Text);
                aluno.Nome = txtNomeCompleto.Text;
                aluno.DataNascimento = Convert.ToDateTime(dtNascimento.Text);
                aluno.Endereco.Bairro.Nome_bairro = txtBairro.Text;
                aluno.Endereco.NumCasa = Convert.ToInt32(txtNumeroCasa.Text);
                aluno.Endereco.NomeRua = txtRua.Text;
                aluno.Endereco.Bairro.Cidade.Id = (Convert.ToInt32(cbCidade.SelectedValue));
                aluno.TelefonePessoal = txtTelefonePessoal.Text;
                aluno.TelefoneFixo = txtTelefoneFixo.Text;
                aluno.TelefoneResponsavel = txtTelefoneResponsavel.Text;
                aluno.TelefoneResponsavel2 = txtTelefoneResponsavel2.Text;
                aluno.Turma.Id = (Convert.ToInt32(cbTurma.SelectedValue));
                alunoModel.AtualizarAluno(aluno, alunoAntigo);
                MessageBox.Show("Aluno Salvo com Sucesso!", "Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void brnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você está preste a excluir um aluno permanentemente, deseja prosseguir?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeletarAluno(id);
                this.Close();
            }
        }

        private void DeletarAluno(int id)
        {
            try
            {
                alunoModel.DeletarAluno(id);
            }
            
            catch(Exception ex)
            {
                throw ex;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
