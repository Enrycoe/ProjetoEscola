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
        Aluno aluno;
        AlunoModel alunoModel = new AlunoModel();
        CidadeModel cidadeModel = new CidadeModel();
        EstadoModel estadoModel = new EstadoModel();
        TurmaModel turmaModel = new TurmaModel();
        
        public FormEditarAluno(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = alunoModel.ReceberAluno(aluno.Id);
            cbEstado.ValueMember = "id";
            cbEstado.DisplayMember = "Sigla";
            cbCidade.ValueMember = "id";
            cbCidade.DisplayMember = "Nome_Cidade";
            cbTurma.ValueMember = "id";
            cbTurma.DisplayMember = "Nome_Turma";
        }

        private void FormEditarAluno_Load(object sender, EventArgs e)
        {

            txtRA.Text = aluno.Id.ToString();
            cbEstado.DataSource = estadoModel.Listar();
            cbTurma.DataSource = turmaModel.Listar();
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
            cbCidade.Text = null;

            DataTable cidadePorEstado = cidadeModel.Listar(Convert.ToInt32(cbEstado.SelectedValue));

            cbCidade.DataSource = cidadePorEstado;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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
            int idade = aluno.CalcularIdade(Convert.ToDateTime(dtNascimento.Text));
            if (idade < aluno.IdadeMinima || idade > aluno.IdadeMaxima)
            {
                MessageBox.Show("O aluno precisa estar entre 13 e 21 anos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNascimento.Focus();
                return;
            }
            Atualizar();
            this.Close();
        }

        private void Atualizar()
        {

            try
            {
                Aluno alunoAtualizado = new Aluno();
                alunoAtualizado.Endereco = new Endereco();
                alunoAtualizado.Endereco.Bairro = new Bairro(); 
                alunoAtualizado.Endereco.Bairro.Cidade = new Cidade();
                alunoAtualizado.Turma = new Turma();

                alunoAtualizado.Id = Convert.ToInt32(txtRA.Text);
                alunoAtualizado.Nome = txtNomeCompleto.Text;
                alunoAtualizado.DataNascimento = Convert.ToDateTime(dtNascimento.Text);
                alunoAtualizado.Idade = alunoAtualizado.CalcularIdade(alunoAtualizado.DataNascimento);
                alunoAtualizado.Endereco.Bairro.Nome_bairro = txtBairro.Text;
                alunoAtualizado.Endereco.NumCasa = Convert.ToInt32(txtNumeroCasa.Text);
                alunoAtualizado.Endereco.NomeRua = txtRua.Text;
                alunoAtualizado.Endereco.Bairro.Cidade.Id = (Convert.ToInt32(cbCidade.SelectedValue));
                alunoAtualizado.TelefonePessoal = txtTelefonePessoal.Text;
                alunoAtualizado.TelefoneFixo = txtTelefoneFixo.Text;
                alunoAtualizado.TelefoneResponsavel = txtTelefoneResponsavel.Text;
                alunoAtualizado.TelefoneResponsavel2 = txtTelefoneResponsavel2.Text;
                alunoAtualizado.Turma.Id = (Convert.ToInt32(cbTurma.SelectedValue));

                Pessoa pessoa = aluno;
                Pessoa pessoaAtualizada = alunoAtualizado;


                alunoModel.Atualizar(pessoa, pessoaAtualizada);
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
                Deletar();
                this.Close();
            }
        }

        private void Deletar()
        {
            try
            {
                alunoModel.Deletar(aluno.Id);
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
            if (!(Char.IsNumber(e.KeyChar)) && !Char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
