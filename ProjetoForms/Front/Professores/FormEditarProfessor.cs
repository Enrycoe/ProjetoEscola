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
        UsuarioModel usuarioModel = new UsuarioModel();
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
            cbCidade.DisplayMember = "Nome";
        }

        private void FormEditarProfessor_Load(object sender, EventArgs e)
        {
            try
            {
                Usuario usuarioProfessor = usuarioModel.ReceberUsuarioPorProfessor(professor);
                txtLogin.Text = usuarioProfessor.NomeUsuario;
                txtSenha.Text = usuarioProfessor.SenhaUsuario;
                cbEstado.DataSource = estadoModel.BuscarEstados();
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
                cbCidade.Text = null;

                cbCidade.DataSource = cidadeModel.BuscarCidadePorEstado(Convert.ToInt32(cbEstado.SelectedValue));
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
                bool trocouASenha = usuarioModel.VerificarSeTrocouASenha(txtSenha.Text, txtLogin.Text);
                if (trocouASenha)
                {
                    if (MessageBox.Show("Você Atualizou o campo senha, deseja realmente altera-la?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        usuarioModel.AlterarSenha(txtSenha.Text, txtLogin.Text);
                    }
                }
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
                Professor util = new Professor();
                int id = professor.Id;
                int idCidade = Convert.ToInt32(cbCidade.SelectedValue);
                Cidade cidade = new Cidade(idCidade);
                string nomeBairro = txtBairro.Text;
                Bairro bairro = new Bairro(nomeBairro, cidade);
                List<Materia> materias = ReceberMateriasSelecionadas();
                List<Turma> turmas = ReceberTurmasSelecionadas();
                DateTime dataNascimento = Convert.ToDateTime(dtNascimento.Text);
                string nome = txtNomeCompleto.Text;
                string nomeRua = txtRua.Text;
                int numCasa = Convert.ToInt32(txtNumeroCasa.Text);
                Endereco endereco = new Endereco(numCasa, nomeRua, bairro);
                int idade = util.CalcularIdade(dataNascimento);
                string telefoneFixo = txtTelefoneFixo.Text;
                string telefonePessoal = txtTelefonePessoal.Text;
                Professor professorAtualizado = new Professor(id, nome, dataNascimento, idade, endereco, telefonePessoal, telefoneFixo, materias, turmas);
                professorModel.AtualizarPorId(professor, professorAtualizado);
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

                string nome = cbPA.Text;
                int id = 1;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbPB.Checked)
            {
                string nome = cbPB.Text;
                int id = 2;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbPC.Checked)
            {
                
                string nome = cbPC.Text;
                int id = 3;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbPD.Checked)
            {
                
                string nome = cbPD.Text;
                int id = 4;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbSA.Checked)
            {
                ;
                string nome = cbSA.Text;
                int id = 5;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbSB.Checked)
            {
                
                string nome = cbSB.Text;
                int id = 6;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbSC.Checked)
            {
                
                string nome = cbSC.Text;
                int id = 7;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbSD.Checked)
            {
                
                string nome = cbSD.Text;
                int id = 8;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbTA.Checked)
            {
                
                string nome = cbTA.Text;
                int id = 9;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbTB.Checked)
            {
                
                string nome = cbTB.Text;
                int id = 10;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbTC.Checked)
            {
                
                string nome = cbTC.Text;
                int id = 11;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            if (cbTD.Checked)
            {
                
                string nome = cbTD.Text;
                int id = 12;
                Turma turma = new Turma(id, nome);
                turmas.Add(turma);
            }
            return turmas;
        }

        private List<Materia> ReceberMateriasSelecionadas()
        {
            List<Materia> materias = new List<Materia>();
            if (cbArtes.Checked)
            {

                string nome = cbArtes.Text;
                int id = 1;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbEducacaoF.Checked)
            {

                string nome = cbEducacaoF.Text;
                int id = 2;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbFilosofia.Checked)
            {

                string nome = cbFilosofia.Text;
                int id = 3;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbSociologia.Checked)
            {

                string nome = cbSociologia.Text;
                int id = 4;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbIngles.Checked)
            {

                string nome = cbIngles.Text;
                int id = 5;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbFisica.Checked)
            {

                string nome = cbFisica.Text;
                int id = 6;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbQuímica.Checked)
            {

                string nome = cbQuímica.Text;
                int id = 7;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbBiologia.Checked)
            {

                string nome = cbBiologia.Text;
                int id = 8;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbGeografia.Checked)
            {

                string nome = cbGeografia.Text;
                int id = 9;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbHistoria.Checked)
            {

                string nome = cbHistoria.Text;
                int id = 10;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbMatematica.Checked)
            {

                string nome = cbMatematica.Text;
                int id = 11;
                Materia materia = new Materia(id, nome);
                materias.Add(materia);
            }
            if (cbLinguaP.Checked)
            {

                string nome = cbLinguaP.Text;
                int id = 12;
                Materia materia = new Materia(id, nome);
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
