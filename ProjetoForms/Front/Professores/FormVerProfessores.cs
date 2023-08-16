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
    public partial class FormVerProfessores : Form
    {
        MateriaModel materiaModel = new MateriaModel();
        ProfessorModel professorModel = new ProfessorModel();
        public FormVerProfessores()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



       
        private void FormVerProfessores_Load(object sender, EventArgs e)
        {
            Listar();
            gridProfessores.EnableHeadersVisualStyles = false;
            gridProfessores.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                if (string.IsNullOrEmpty(nome))
                {
                    Listar();
                    return;
                }
                gridProfessores.DataSource = BuscarPorNome(nome);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
           
        }
        private DataTable BuscarPorNome(string nome)
        {
            try
            {
                return professorModel.BuscarPorNome(nome);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
