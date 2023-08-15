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

namespace ProjetoForms.Front.Professores
{
    public partial class FormVerProfessores : Form
    {
        MateriaModel materiaModel = new MateriaModel();
        ProfessorModel professorModel = new ProfessorModel();
        public FormVerProfessores()
        {
            InitializeComponent();
            
        }

        private void FormVerProfessores_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                gridProfessores.DataSource = professorModel.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados: " + ex.Message);
            }
        }

        private void gridProfessores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Professor professor = new Professor();
                professor.Id = Convert.ToInt32(gridProfessores.CurrentRow.Cells[0].Value);
                Form form = new FormEditarProfessor(professor);
                form.ShowDialog();
                Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !Char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
