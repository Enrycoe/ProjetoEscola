using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoForms.Back.Entities;
using ProjetoForms.Back.Model;
using ProjetoForms.Back.DAO;

namespace ProjetoForms.Front.Alunos
{
    public partial class FormCadastrarAluno : Form
    {
        CidadeModel cidadeModel = new CidadeModel();
        EstadoModel estadoModel = new EstadoModel();
        TurmaModel turmaModel = new TurmaModel();
        AlunoModel alunoModel = new AlunoModel();

        public FormCadastrarAluno()
        {
            InitializeComponent();
            cbEstado.ValueMember = "id";
            cbEstado.DisplayMember = "Sigla";
            cbCidade.ValueMember = "id";
            cbCidade.DisplayMember = "Nome_Cidade";
            cbTurma.ValueMember = "id";
            cbTurma.DisplayMember = "Nome_Turma";
        }

        private void FormCadastrarAluno_MouseDown1(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FormCadastrarAluno_Load(object sender, EventArgs e)
        {
            cbEstado.DataSource = estadoModel.Listar();
            cbTurma.DataSource = turmaModel.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Turma = new Turma();
            aluno.Endereco = new Endereco();
            aluno.Endereco.Bairro = new Bairro();
            aluno.Endereco.Bairro.Cidade = new Cidade();
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Nome do aluno não pode estar em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCompleto.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("Nome do bairro não pode estar em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNumeroCasa.Text))
            {
                MessageBox.Show("Número da casa não pode estar em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCompleto.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRua.Text))
            {
                MessageBox.Show("Nome da rua não pode estar em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRua.Focus();
                return;
            }
            DateTime dataNascimento = Convert.ToDateTime(dtNascimento.Text);
            int idade = aluno.CalcularIdade(dataNascimento);
            if (idade < aluno.IdadeMinima || idade > aluno.IdadeMaxima)
            {
                MessageBox.Show("O aluno precisa estar entre 13 e 21 anos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNascimento.Focus();
                return;
            }
            Cadastrar(aluno);
            LimparCampos();

        }

        private void Cadastrar(Aluno aluno)
        {

            try
            {
                aluno.Nome = txtNomeCompleto.Text;
                aluno.DataNascimento = Convert.ToDateTime(dtNascimento.Text);
                aluno.Endereco.Bairro.Nome_bairro = txtBairro.Text;
                aluno.Endereco.NumCasa = Convert.ToInt32(txtNumeroCasa.Text);
                aluno.Endereco.NomeRua = txtRua.Text;
                aluno.Endereco.Bairro.Cidade.Id = (Convert.ToInt32(cbCidade.SelectedValue));
                aluno.TelefonePessoal = txtTelefonePessoal.Text;
                aluno.TelefoneFixo = txtTelefoneFixo.Text;
                aluno.Idade = aluno.CalcularIdade(aluno.DataNascimento);
                aluno.TelefoneResponsavel = txtTelefoneResponsavel.Text;
                aluno.TelefoneResponsavel2 = txtTelefoneResponsavel2.Text;
                aluno.Turma.Id = (Convert.ToInt32(cbTurma.SelectedValue));
                Pessoa pessoa = aluno;
                alunoModel.Cadastrar(pessoa);
                MessageBox.Show("Aluno Cadastrado com Sucesso!", "Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEstado_TextChanged(object sender, EventArgs e)
        {
            cbCidade.Text = null;

            DataTable cidadePorEstado = cidadeModel.Listar(Convert.ToInt32(cbEstado.SelectedValue));

            cbCidade.DataSource = cidadePorEstado;

        }

        private void LimparCampos()
        {
            txtNomeCompleto.Text = "";
            dtNascimento.Text = "";
            txtBairro.Text = "";
            txtNumeroCasa.Text = "";
            txtTelefonePessoal.Text = "";
            txtTelefoneFixo.Text = "";
            txtTelefoneResponsavel.Text = "";
            txtTelefoneResponsavel2.Text = "";
        }

        private void txtNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !Char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !Char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtRua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !Char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}