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
    public partial class FormEditarProfessor : Form
    {
        ProfessorModel professorModel = new ProfessorModel();
        Professor professor;
        EstadoModel estadoModel = new EstadoModel();
        CidadeModel cidadeModel = new CidadeModel();    
        public FormEditarProfessor(Professor professor)
        {
            InitializeComponent();
            this.professor = professor;
            cbEstado.ValueMember = "id";
            cbEstado.DisplayMember = "Sigla";
            cbCidade.ValueMember = "id";
            cbCidade.DisplayMember = "Nome_Cidade";
        }

        private void FormEditarProfessor_Load(object sender, EventArgs e)
        {
            try
            {
                cbEstado.DataSource = estadoModel.Listar();
                cbEstado.SelectedValue = professor.Endereco.Bairro.Cidade.Estado.Id;
                cbCidade.SelectedValue = professor.Endereco.Bairro.Cidade.Id;
                txtNomeCompleto.Text = professor.Nome;
                txtBairro.Text = professor.Endereco.Bairro.NomeBairro;
                dtNascimento.Text = professor.DataNascimento.ToString();
                txtRua.Text = professor.Endereco.NomeRua;
                txtNumeroCasa.Text = professor.Endereco.NumCasa.ToString();
                txtTelefonePessoal.Text = professor.TelefonePessoal;
                txtTelefoneFixo.Text = professor.TelefoneFixo;

                foreach (Materia materia in professor.Materias)
                {
                    switch (materia.Id)
                    {
                        case 1:
                            cbArtes.Checked = true;
                            break;
                        case 2:
                            cbEducacaoF.Checked = true;
                            break;
                        case 3:
                            cbFilosofia.Checked = true;
                            break;
                        case 4:
                            cbSociologia.Checked = true;
                            break;
                        case 5:
                            cbIngles.Checked = true;
                            break;
                        case 6:
                            cbFisica.Checked = true;
                            break;
                        case 7:
                            cbQuímica.Checked = true;
                            break;
                        case 8:
                            cbBiologia.Checked = true;
                            break;
                        case 9:
                            cbGeografia.Checked = true;
                            break;
                        case 10:
                            cbHistoria.Checked = true;
                            break;
                        case 11:
                            cbMatematica.Checked = true;
                            break;
                        case 12:
                            cbLinguaP.Checked = true;
                            break;
                    }
                }

                foreach (Turma turma in professor.Turmas)
                {
                    switch (turma.Id)
                    {
                        case 1:
                            cbPA.Checked = true;
                            break;
                        case 2:
                            cbPB.Checked = true;
                            break;
                        case 3:
                            cbPC.Checked = true;
                            break;
                        case 4:
                            cbPD.Checked = true;
                            break;
                        case 5:
                            cbSA.Checked = true;
                            break;
                        case 6:
                            cbSB.Checked = true;
                            break;
                        case 7:
                            cbSC.Checked = true;
                            break;
                        case 8:
                            cbSD.Checked = true;
                            break;
                        case 9:
                            cbTA.Checked = true;
                            break;
                        case 10:
                            cbTB.Checked = true;
                            break;
                        case 11:
                            cbTC.Checked = true;
                            break;
                        case 12:
                            cbTD.Checked = true;
                            break;
                    }
                }
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

        private void brnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você está preste a excluir um professor permanentemente, deseja prosseguir?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                professorModel.DeletarPorId(professor.Id);
                MessageBox.Show("Professor deletado com sucesso", "Deletado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void cbEstado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbCidade.Text = "";

                DataTable cidadePorEstado = cidadeModel.Listar(Convert.ToInt32(cbEstado.SelectedValue));

                cbCidade.DataSource = cidadePorEstado;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = new Professor();
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
                Professor professorAtualizado = new Professor();
                professorAtualizado.Endereco = new Endereco();
                professorAtualizado.Endereco.Bairro = new Bairro();
                professorAtualizado.Endereco.Bairro.Cidade = new Cidade();  
                professorAtualizado.Endereco.Bairro.Cidade.Id = Convert.ToInt32(cbCidade.SelectedValue);
                professorAtualizado.Id = professor.Id;
                professorAtualizado.Materias = new List<Materia>();
                professorAtualizado.Turmas = new List<Turma>();
                professorAtualizado.Materias.Clear();
                professorAtualizado.Turmas.Clear();
                professorAtualizado.Materias = ReceberMateriasSelecionadas();
                professorAtualizado.Turmas = ReceberTurmasSelecionadas();
                professorAtualizado.DataNascimento = Convert.ToDateTime(dtNascimento.Text);
                professorAtualizado.Nome = txtNomeCompleto.Text;
                professorAtualizado.Endereco.NomeRua = txtRua.Text;
                professorAtualizado.Endereco.NumCasa = Convert.ToInt32(txtNumeroCasa.Text);
                professorAtualizado.Endereco.Bairro.NomeBairro = txtBairro.Text;
                professorAtualizado.TelefoneFixo = txtTelefoneFixo.Text;
                professorAtualizado.TelefonePessoal = txtTelefonePessoal.Text;
                Pessoa pessoa = professor;
                Pessoa pessoaAtualizada = professorAtualizado;
                professorModel.AtualizarPorId(pessoa, professorAtualizado);
                MessageBox.Show("Professor atualizado com sucesso", "Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
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
  

        private void FormEditarProfessor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
