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
using System.Runtime.InteropServices;

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
            cbCidade.DisplayMember = "Nome";
            cbTurma.ValueMember = "id";
            cbTurma.DisplayMember = "Nome_Turma";
        }

        private void FormCadastrarAluno_Load(object sender, EventArgs e)
        {
            try
            {
                cbEstado.DataSource = estadoModel.BuscarEstados();
                cbTurma.DataSource = turmaModel.BuscarTurmas();
                cbTurma.SelectedIndex = 12;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();
               
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
                if (!txtTelefoneFixo.MaskCompleted)
                {
                    MessageBox.Show("Gay");
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
                Cadastrar();
                LimparCampos();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void Cadastrar()
        {

            try
            {
                Aluno util = new Aluno();
                string nome = txtNomeCompleto.Text;
                DateTime dataNascimento = Convert.ToDateTime(dtNascimento.Text);
                int idCidade = (Convert.ToInt32(cbCidade.SelectedValue));
                Cidade cidade = new Cidade(idCidade);
                string nomeBairro = txtBairro.Text;
                Bairro bairro = new Bairro(nomeBairro, cidade);
                string nomeRua = txtRua.Text;
                int numCasa = Convert.ToInt32(txtNumeroCasa.Text);
                Endereco endereco = new Endereco(numCasa, nomeRua, bairro);
                string telefonePessoal = txtTelefonePessoal.Text;
                string telefoneFixo = txtTelefoneFixo.Text;
                int idade = util.CalcularIdade(dataNascimento);
                string telefoneResponsavel = txtTelefoneResponsavel.Text;
                string telefoneResponsavel2 = txtTelefoneResponsavel2.Text;
                int idTurma = (Convert.ToInt32(cbTurma.SelectedValue));
                Turma turma = new Turma(idTurma);
                Aluno aluno = new Aluno(nome, dataNascimento,idade,endereco,telefonePessoal,telefoneFixo,telefoneResponsavel,telefoneResponsavel2,turma);
                alunoModel.Cadastrar(aluno);
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
            try
            {
                cbCidade.Text = null;

                cbCidade.DataSource = cidadeModel.BuscarCidadePorEstado(Convert.ToInt32(cbEstado.SelectedValue));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }

        private void LimparCampos()
        {
            txtNomeCompleto.Text = "";
            dtNascimento.Text = "";
            txtBairro.Text = "";
            txtNumeroCasa.Text = "";
            txtRua.Text = "";
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormCadastrarAluno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}