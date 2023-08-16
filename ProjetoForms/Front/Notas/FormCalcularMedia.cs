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

namespace ProjetoForms.Front.Notas
{
    public partial class FormCalcularMedia : Form
    {
        int quantidadeProvas = 0;
        Aluno aluno;
        Media media = new Media();
        double somaNotas = 0;
        AlunoModel alunoModel = new AlunoModel();
        MateriaModel materiaModel = new MateriaModel();
        ProvaModel provaModel = new ProvaModel();
        BimestreModel bimestreModel = new BimestreModel();
        MediaModel mediaModel = new MediaModel();

        public FormCalcularMedia(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = alunoModel.ReceberAluno(aluno.Id);
            cbMateria.ValueMember = "ID";
            cbMateria.DisplayMember = "Nome_da_Materia";
            cbBimestre.ValueMember = "ID";
            cbBimestre.DisplayMember = "bimestre";
            cbMateria.DataSource = materiaModel.Listar();
            cbBimestre.DataSource = bimestreModel.Listar();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            Prova prova = new Prova();
            prova.Materia = new Materia();
            prova.Materia.Id = Convert.ToInt32(cbMateria.SelectedValue);
            prova.Aluno = aluno;
            Materia materia = new Materia();
            materia.Id = Convert.ToInt32(cbMateria.SelectedValue);
            dataGridProvas.DataSource = provaModel.ListarProvaPorMateria(prova);
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
                    quantidadeProvas++;
                    somaNotas += Convert.ToDouble(dataGridProvas.CurrentRow.Cells[1].Value);
                    media.ValorMedia = somaNotas / quantidadeProvas;
                    txtMedia.Text = media.ValorMedia.ToString("F");
                    dataGridProvas.CurrentRow.Cells[0].Value = 1;
                }
                else
                {
                    quantidadeProvas--;
                    somaNotas -= Convert.ToDouble(dataGridProvas.CurrentRow.Cells[1].Value);
                    media.ValorMedia = somaNotas / quantidadeProvas;
                    txtMedia.Text = media.ValorMedia.ToString("F");
                    dataGridProvas.CurrentRow.Cells[0].Value = 0;
                }
            }

            if (txtMedia.Text == "NaN")
            {
                txtMedia.Text = "0";
            }
        }

        private void btnSalvarMedia_Click(object sender, EventArgs e)
        {
            List<Prova> provas = new List<Prova>();
            bool provaSelecionada = false;
            foreach (DataGridViewRow row in dataGridProvas.Rows)
            {
                if (Convert.ToDouble(row.Cells[0].Value) == 1)
                {
                    provaSelecionada = true;
                    Prova prova = new Prova();
                    prova.Id = Convert.ToInt32(row.Cells[2].Value);
                    provas.Add(prova);
                }
            }
            if (!provaSelecionada)
            {
                MessageBox.Show("Selecione pelo menos uma prova para cadastrar um média", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            media.Materia = new Materia();
            media.Materia.Id = Convert.ToInt32(cbMateria.SelectedValue);
            media.Bimestre = new Bimestre();
            media.Bimestre.Id = Convert.ToInt32(cbBimestre.SelectedValue);
            media.Aluno = aluno;
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
            foreach (Prova prova in provas)
            {
                prova.Media = new Media();
                prova.Media.Id = ReceberIDUltimaMedia();
                DesignarProvaMedia(prova);
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

                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void DesignarProvaMedia(Prova prova)
        {
            provaModel.DesignarProvaMedia(prova);
        }

        private int ReceberIDUltimaMedia()
        {
            return mediaModel.ReceberIDUltimaMedia();
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
