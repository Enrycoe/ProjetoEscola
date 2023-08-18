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

namespace ProjetoForms.Front.Professores
{
    public partial class FormCadastrarProfessor : Form
    {
        ProfessorModel professorModel = new ProfessorModel();
        EstadoModel estadoModel = new EstadoModel();
        CidadeModel cidadeModel = new CidadeModel();
        public FormCadastrarProfessor()
        {
            InitializeComponent();
            cbEstado.ValueMember = "id";
            cbEstado.DisplayMember = "Sigla";
            cbCidade.ValueMember = "id";
            cbCidade.DisplayMember = "Nome_Cidade";
        }
        private void FormCadastrarProfessor_Load(object sender, EventArgs e)
        {
            try
            {
                cbEstado.DataSource = estadoModel.Listar();
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

                DataTable cidadePorEstado = cidadeModel.Listar(Convert.ToInt32(cbEstado.SelectedValue));

                cbCidade.DataSource = cidadePorEstado;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = new Professor();
                professor.Endereco = new Endereco();
                professor.Endereco.Bairro = new Bairro();
                professor.Endereco.Bairro.Cidade = new Cidade();

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
                int idade = professor.CalcularIdade(dataNascimento);
                if (idade < professor.IdadeMinima || idade > professor.IdadeMaxima)
                {
                    MessageBox.Show("O professor precisa estar acima de 21 anos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtNascimento.Focus();
                    return;
                }
                Cadastrar(professor);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void Cadastrar(Professor professor)
        {
            try
            {
                professor.Endereco.Bairro.Cidade.Id = Convert.ToInt32(cbCidade.SelectedValue);
                professor.Materias = ReceberMateriasSelecionadas();
                professor.Turmas = ReceberTurmasSelecionadas();
                professor.DataNascimento = Convert.ToDateTime(dtNascimento.Text);
                professor.Nome = txtNomeCompleto.Text;
                professor.Endereco.NomeRua = txtRua.Text;
                professor.Endereco.NumCasa = Convert.ToInt32(txtNumeroCasa.Text);
                professor.Endereco.Bairro.Nome_bairro = txtBairro.Text;
                professor.TelefoneFixo = txtTelefoneFixo.Text;
                professor.TelefonePessoal = txtTelefonePessoal.Text;
                Pessoa pessoa = professor;
                professorModel.Cadastrar(pessoa);
                MessageBox.Show("Professor cadastrado com sucesso", "Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private List<Turma> ReceberTurmasSelecionadas()
        {
            List<Turma> turmas = new List<Turma>();
            if (cbPA.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbPA.Text;
                turma.Id = 1;
                turmas.Add(turma);
            }
            if (cbPB.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbPB.Text;
                turma.Id = 2;
                turmas.Add(turma);
            }
            if (cbPC.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbPC.Text;
                turma.Id = 3;
                turmas.Add(turma);
            }
            if (cbPD.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbPD.Text;
                turma.Id = 4;
                turmas.Add(turma);
            }
            if (cbSA.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbSA.Text;
                turma.Id = 5;
                turmas.Add(turma);
            }
            if (cbSB.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbSB.Text;
                turma.Id = 6;
                turmas.Add(turma);
            }
            if (cbSC.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbSC.Text;
                turma.Id = 7;
                turmas.Add(turma);
            }
            if (cbSD.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbSD.Text;
                turma.Id = 8;
                turmas.Add(turma);
            }
            if (cbTA.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbTA.Text;
                turma.Id = 9;
                turmas.Add(turma);
            }
            if (cbTB.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbTB.Text;
                turma.Id = 10;
                turmas.Add(turma);
            }
            if (cbTC.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbTC.Text;
                turma.Id = 11;
                turmas.Add(turma);
            }
            if (cbTD.Checked)
            {
                Turma turma = new Turma();
                turma.Nome = cbTD.Text;
                turma.Id = 12;
                turmas.Add(turma);
            }
            return turmas;
        }

        private List<Materia> ReceberMateriasSelecionadas()
        {
            List<Materia> materias = new List<Materia>();
            if (cbArtes.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbArtes.Text;
                materia.Id = 1;
                materias.Add(materia);
            }
            if (cbEducacaoF.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbEducacaoF.Text;
                materia.Id = 2;
                materias.Add(materia);
            }
            if (cbFilosofia.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbFilosofia.Text;
                materia.Id = 3;
                materias.Add(materia);
            }
            if (cbSociologia.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbSociologia.Text;
                materia.Id = 4;
                materias.Add(materia);
            }
            if (cbIngles.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbIngles.Text;
                materia.Id = 5;
                materias.Add(materia);
            }
            if (cbFisica.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbFisica.Text;
                materia.Id = 6;
                materias.Add(materia);
            }
            if (cbQuímica.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbQuímica.Text;
                materia.Id = 7;
                materias.Add(materia);
            }
            if (cbBiologia.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbBiologia.Text;
                materia.Id = 8;
                materias.Add(materia);
            }
            if (cbGeografia.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbGeografia.Text;
                materia.Id = 9;
                materias.Add(materia);
            }
            if (cbHistoria.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbHistoria.Text;
                materia.Id = 10;
                materias.Add(materia);
            }
            if (cbMatematica.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbMatematica.Text;
                materia.Id = 11;
                materias.Add(materia);
            }
            if (cbLinguaP.Checked)
            {
                Materia materia = new Materia();
                materia.NomeMateria = cbLinguaP.Text;
                materia.Id = 12;
                materias.Add(materia);
            }
            return materias;
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
            
            cbPA.Checked = false;
            cbPB.Checked = false;
            cbPC.Checked = false;   
            cbPD.Checked = false;   
            cbSA.Checked = false;
            cbSB.Checked = false;
            cbSC.Checked = false;
            cbSD.Checked = false;
            cbTA.Checked = false;
            cbTB.Checked = false;
            cbTC.Checked = false;
            cbTD.Checked = false;
            cbArtes.Checked = false;
            cbEducacaoF.Checked = false;
            cbFilosofia.Checked = false;
            cbSociologia.Checked = false;
            cbIngles.Checked = false;
            cbFisica.Checked = false;
            cbQuímica.Checked = false;
            cbBiologia.Checked = false;
            cbGeografia.Checked = false;
            cbHistoria.Checked = false;
            cbMatematica.Checked = false;
            cbLinguaP.Checked = false;
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
        private void FormCadastrarProfessor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
