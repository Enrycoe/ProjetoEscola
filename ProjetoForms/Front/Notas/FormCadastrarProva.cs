using ProjetoForms.Back.Entities;
using ProjetoForms.Back.Model;
using ProjetoForms.Back.Service;
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

namespace ProjetoForms.Front.Notas
{
    public partial class FormCadastrarProva : Form
    {
        ProvaModel provaModel = new ProvaModel();
        AlunoModel alunoModel = new AlunoModel();
        MateriaModel materiaModel = new MateriaModel();
        Aluno aluno;
        Professor professor = new Professor();
        
        public FormCadastrarProva(Aluno aluno, Professor professor)
        {
            InitializeComponent();
            try
            {
                this.aluno = aluno;
                this.professor = professor;
                cbMateria.ValueMember = "ID";
                cbMateria.DisplayMember = "NomeMateria";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void FormCadastrarProva_Load(object sender, EventArgs e)
        {
            try
            {
                lblAluno.Text = "Aluno: " + aluno.Nome.ToString();
                cbMateria.DataSource = materiaModel.BuscarMateriaPorProfessor(professor);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnCadastrarProva_Click(object sender, EventArgs e)
        {
            try
            {
                double nota = Convert.ToDouble(txtNota.Text);
                bool notaValida = ServicesNotas.VerificarSeNotaEValida(nota);
                if (!notaValida)
                {
                    MessageBox.Show("Insira um valor válido! A nota deve estar entre 0 e 10", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string descricao = txtDesc.Text;
                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("Insira uma descrição para a prova", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int idMateria = Convert.ToInt32(cbMateria.SelectedValue);
                Materia materia = new Materia(idMateria);
                Prova prova = new Prova(nota, descricao, materia, aluno);
                
                CadastrarProva(prova);
                txtDesc.Text = null;
                txtNota.Text = null;    
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void CadastrarProva(Prova prova)
        {
            try
            {
                provaModel.CadastrarProva(prova);
                MessageBox.Show("Prova Cadstrada com sucesso!", "Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormCadastrarProva_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
