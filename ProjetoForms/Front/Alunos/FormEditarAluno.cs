using ProjetoForms.Back.Entities;
using ProjetoForms.Back.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.aluno = aluno;
            cbEstado.ValueMember = "id";
            cbEstado.DisplayMember = "Sigla";
            cbCidade.ValueMember = "id";
            cbCidade.DisplayMember = "Nome";
            cbTurma.ValueMember = "id";
            cbTurma.DisplayMember = "Nome_Turma";
        }

        private void FormEditarAluno_Load(object sender, EventArgs e)
        {
            try
            {
                txtRA.Text = aluno.Id.ToString();
                cbEstado.DataSource = estadoModel.BuscarEstados();
                cbTurma.DataSource = turmaModel.BuscarTurmas();
                cbEstado.SelectedValue = aluno.Endereco.Bairro.Cidade.Estado.Id;
                cbCidade.SelectedValue = aluno.Endereco.Bairro.Cidade.Id;
                cbTurma.SelectedValue = aluno.Turma.Id;
                txtNomeCompleto.Text = aluno.Nome;
                txtBairro.Text = aluno.Endereco.Bairro.NomeBairro;
                dtNascimento.Text = aluno.DataNascimento.ToString();
                txtRua.Text = aluno.Endereco.NomeRua;
                txtNumeroCasa.Text = aluno.Endereco.NumCasa.ToString();
                txtTelefonePessoal.Text = aluno.TelefonePessoal;
                txtTelefoneFixo.Text = aluno.TelefoneFixo;
                txtTelefoneResponsavel.Text = aluno.TelefoneResponsavel;
                txtTelefoneResponsavel2.Text = aluno.TelefoneResponsavel2;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
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
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void Atualizar()
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
                int id = Convert.ToInt32(txtRA.Text);
                Turma turma = new Turma(idTurma);
                Aluno alunoAtualizado = new Aluno(id, nome, dataNascimento, idade, endereco, telefonePessoal, telefoneFixo, telefoneResponsavel, telefoneResponsavel2, turma);
                alunoModel.AtualizarPorId(aluno, alunoAtualizado);
                MessageBox.Show("Aluno Salvo com Sucesso!", "Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void brnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você está preste a excluir um aluno permanentemente, deseja prosseguir?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeletarPorId();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void DeletarPorId()
        {
            try
            {
                alunoModel.DeletarPorId(aluno.Id);
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormEditarAluno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
