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
    public partial class FormCalcularMedia : Form
    {
        int quantidadeProvas = 0;
        Aluno aluno;
        Professor professor;
        double notaMedia;
        double somaNotas = 0;
        AlunoModel alunoModel = new AlunoModel();
        MateriaModel materiaModel = new MateriaModel();
        ProvaModel provaModel = new ProvaModel();
        BimestreModel bimestreModel = new BimestreModel();
        MediaModel mediaModel = new MediaModel();

        public FormCalcularMedia(Aluno aluno, Professor professor)
        {
            InitializeComponent();
            try
            {
                this.professor = professor;
                this.aluno = aluno;
                cbMateria.ValueMember = "Id";
                cbMateria.DisplayMember = "NomeMateria";
                cbBimestre.ValueMember = "Id";
                cbBimestre.DisplayMember = "Nome";
                cbMateria.DataSource = materiaModel.BuscarMateriaPorProfessor(professor);
                cbBimestre.DataSource = bimestreModel.BuscarBimestres();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.professor = professor;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridProvas.AutoGenerateColumns = false;
                Prova prova = new Prova();
                prova.Materia = new Materia();
                prova.Materia.Id = Convert.ToInt32(cbMateria.SelectedValue);
                prova.Aluno = aluno;
                Materia materia = new Materia();
                materia.Id = Convert.ToInt32(cbMateria.SelectedValue);
                dataGridProvas.DataSource = provaModel.BuscarProvaPorMateria(prova);
                quantidadeProvas = 0;
                somaNotas = 0;
                notaMedia = 0;
                txtMedia.Text = "0";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void FormCalcularMedia_Load(object sender, EventArgs e)
        {
            txtMedia.Text = "0";
            lblNome.Text = "Aluno: " + aluno.Nome;
        }

        private void dataGridViewProvas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToInt32(dataGridProvas.CurrentRow.Cells[0].Value) == 0)
                {
                    dataGridProvas.CurrentRow.Cells[0].Value = 1;
                    quantidadeProvas++;
                    somaNotas += Convert.ToDouble(dataGridProvas.CurrentRow.Cells[1].Value);
                    notaMedia = Services.CalcularMediaPorBimestre(quantidadeProvas, somaNotas);
                    txtMedia.Text = notaMedia.ToString("F");                  
                }
                else
                {
                    dataGridProvas.CurrentRow.Cells[0].Value = 0;
                    quantidadeProvas--;
                    somaNotas -= Convert.ToDouble(dataGridProvas.CurrentRow.Cells[1].Value);
                    notaMedia = Services.CalcularMediaPorBimestre(quantidadeProvas, somaNotas);
                    txtMedia.Text = notaMedia.ToString("F");                
                }
            }

            if (txtMedia.Text == "NaN")
            {
                txtMedia.Text = "0";
            }
        }

        private void btnSalvarMedia_Click(object sender, EventArgs e)
        {
            try
            {
                List<Prova> provas = new List<Prova>();
                bool provaSelecionada = false;
                foreach (DataGridViewRow row in dataGridProvas.Rows)
                {
                    if (Convert.ToDouble(row.Cells[0].Value) == 1)
                    {
                        provaSelecionada = true;
                        int idProva = Convert.ToInt32(row.Cells[3].Value);
                        Prova prova = new Prova(idProva);
                        provas.Add(prova);
                    }
                }
                if (!provaSelecionada)
                {
                    MessageBox.Show("Selecione pelo menos uma prova para cadastrar um média", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int idMateria = Convert.ToInt32(cbMateria.SelectedValue);
                Materia materia = new Materia(idMateria);
               int idBimestre = Convert.ToInt32(cbBimestre.SelectedValue);
                Bimestre bimestre = new Bimestre(idBimestre);
                Media media = new Media(notaMedia, bimestre, materia, aluno);
                
                if (mediaModel.VerificarMediaExistente(media))
                {
                    CadastrarMedia(media);
                }
                else
                {
                    if (MessageBox.Show("Já existe uma média para este aluno nesta matéria e neste bimestre. Você deseja substituir?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        mediaModel.ExcluirMediaExistente(media);
                        CadastrarMedia(media);
                    }
                    else
                    {
                        return;
                    }
                }
                int idMedia = ReceberIDUltimaMedia();
                Media mediaProva = new Media(idMedia);
                foreach (Prova prova in provas)
                {                  
                    prova.Media = mediaProva;
                    DesignarProvaMedia(prova);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void CadastrarMedia(Media media)
        {
            try
            {
                mediaModel.CadastrarMedia(media);
                MessageBox.Show("Media Cadstrada com sucesso!", "Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void DesignarProvaMedia(Prova prova)
        {
            try
            {
                provaModel.DesignarProvaMedia(prova);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private int ReceberIDUltimaMedia()
        {
            try
            {
                return mediaModel.ReceberIDUltimaMedia();
            }
            catch (Exception ex)
            {

                throw ex;
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

        private void FormCalcularMedia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
