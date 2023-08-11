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
    }
}
