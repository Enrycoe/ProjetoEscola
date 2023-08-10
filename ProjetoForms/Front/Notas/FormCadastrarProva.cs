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

namespace ProjetoForms.Front.Notas
{
    public partial class FormCadastrarProva : Form
    {
        ProvaModel provaModel = new ProvaModel();
        AlunoModel alunoModel = new AlunoModel();
        MateriaModel materiaModel = new MateriaModel();
        Aluno aluno;
        int x = 0;
        int y = 0;
        public FormCadastrarProva(Aluno aluno)
        {
            this.aluno = aluno;
            InitializeComponent();
            cbMateria.ValueMember = "ID";
            cbMateria.DisplayMember = "Nome_da_Materia";
        }

        private void FormCadastrarProva_Load(object sender, EventArgs e)
        {
            this.aluno = alunoModel.ReceberAluno(aluno.Id);
            lblAluno.Text = "Aluno: " + aluno.Nome.ToString();
            cbMateria.DataSource = materiaModel.Listar();
        }

        private void btnCadastrarProva_Click(object sender, EventArgs e)
        {
            try
            {
                Prova prova = new Prova();
                prova.Materia = new Materia();
                prova.Nota = Convert.ToDouble(txtNota.Text);
                if (prova.Nota > prova.NotaMaxima || prova.Nota < prova.NotaMinima)
                {
                    MessageBox.Show("Insira um valor válido! A nota deve estar entre 0 e 10", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                prova.Descricao = txtDesc.Text;
                if (string.IsNullOrEmpty(prova.Descricao))
                {
                    MessageBox.Show("Insira uma descrição para a prova", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                prova.Materia.Id = Convert.ToInt32(cbMateria.SelectedValue);
                CadastrarProva(prova, aluno);
            }
            catch (Exception)
            {

                MessageBox.Show("Insira um valor válido!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  
        }

        private void CadastrarProva(Prova prova, Aluno aluno)
        {
            try
            {
                provaModel.CadastrarProva(prova, aluno);
                MessageBox.Show("Prova Cadstrada com sucesso!", "Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
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
    }
}
