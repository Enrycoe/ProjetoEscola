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
    public partial class FormBoletim : Form
    {
        Aluno aluno;
        AlunoModel alunoModel = new AlunoModel();
        MediaModel mediaModel = new MediaModel();
        Media media = new Media();
        
        public FormBoletim(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
        }

        private void lblNome_Load(object sender, EventArgs e)
        {
            try
            {
                lblNome.Text = aluno.Nome;
                lblRA.Text = aluno.Id.ToString();
                lblTurma.Text = aluno.Turma.Nome.ToString();
                ReceberMedia();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void ReceberMedia()
        {
            try
            {
                ReceberMediaArtes();
                ReceberMediaEducacaoFisica();
                ReceberMediaFilosifia();
                ReceberMediaSociologia();
                ReceberMediaIngles();
                ReceberMediaFisica();
                ReceberMediaQuimica();
                ReceberMediaBiologia();
                ReceberMediaGeografia();
                ReceberMediaHistoria();
                ReceberMediaMatematica();
                ReceberMediaPortugues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ReceberMediaArtes()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 1);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 1);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 1);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 1);

                lbl1Artes.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2Artes.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3Artes.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4Artes.Text = ServicesNotas.MostrarNotaOuNula(media4);

                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMArtes.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSArtes.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        private void ReceberMediaEducacaoFisica()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 2);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 2);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 2);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 2);

                lbl1EF.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2EF.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3EF.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4EF.Text = ServicesNotas.MostrarNotaOuNula(media4);

                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMEF.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSEF.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ReceberMediaFilosifia()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 3);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 3);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 3);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 3);

                lbl1Filosifia.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2Filosifia.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3Filosifia.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4Filosifia.Text = ServicesNotas.MostrarNotaOuNula(media4);

                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMFilosifia.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSFilosifia.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ReceberMediaSociologia()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 4);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 4);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 4);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 4);

                lbl1Sociologia.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2Sociologia.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3Sociologia.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4Sociologia.Text = ServicesNotas.MostrarNotaOuNula(media4);

                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMSociologia.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSSociologia.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ReceberMediaIngles()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 5);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 5);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 5);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 5);
                lbl1Ingles.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2Ingles.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3Ingles.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4Ingles.Text = ServicesNotas.MostrarNotaOuNula(media4);
                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMIngles.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSIngles.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ReceberMediaFisica()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 6);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 6);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 6);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 6);
                lbl1Fisica.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2Fisica.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3Fisica.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4Fisica.Text = ServicesNotas.MostrarNotaOuNula(media4);
                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMFisica.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSFisica.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ReceberMediaQuimica()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 7);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 7);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 7);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 7);
                lbl1Quimica.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2Quimica.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3Quimica.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4Quimica.Text = ServicesNotas.MostrarNotaOuNula(media4);
                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMQuimica.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSQuimica.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        private void ReceberMediaBiologia()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 8);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 8);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 8);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 8);
                lbl1Biologia.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2Biologia.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3Biologia.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4Biologia.Text = ServicesNotas.MostrarNotaOuNula(media4);
                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMBiologia.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSBiologia.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ReceberMediaGeografia()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 9);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 9);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 9);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 9);
                lbl1Geografia.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2Geografia.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3Geografia.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4Geografia.Text = ServicesNotas.MostrarNotaOuNula(media4);
                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMGeografia.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSGeografia.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ReceberMediaHistoria()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 10);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 10);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 10);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 10);
                lbl1Historia.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2Historia.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3Historia.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4Historia.Text = ServicesNotas.MostrarNotaOuNula(media4);
                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMHistoria.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSHistoria.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ReceberMediaMatematica()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 11);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 11);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 11);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 11);
                lbl1Matematica.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2Matematica.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3Matematica.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4Matematica.Text = ServicesNotas.MostrarNotaOuNula(media4);
                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMMatematica.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSMatematica.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        private void ReceberMediaPortugues()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 12);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 12);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 12);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 12);
                lbl1LP.Text = ServicesNotas.MostrarNotaOuNula(media1);
                lbl2LP.Text = ServicesNotas.MostrarNotaOuNula(media2);
                lbl3LP.Text = ServicesNotas.MostrarNotaOuNula(media3);
                lbl4LP.Text = ServicesNotas.MostrarNotaOuNula(media4);
                double mediaFinal = ServicesNotas.CalcularMediaFinal(media1, media2, media3, media4);
                lblMLP.Text = ServicesNotas.MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSLP.Text = ServicesNotas.AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
       

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormBoletim_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
