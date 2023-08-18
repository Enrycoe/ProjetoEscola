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

        private string MostrarNotaOuNula(double media)
        {
            if (media == -1)
            {
                return "--,--";
            }
            else
            {
                return media.ToString("F");
            }
        }

        private string MostrarMediaFinal(double mediaFinal, double media1, double media2, double media3, double media4)
        {
            if(media1 == -1 || media2 == -1 || media3 == -1 || media4 == -1)
            {
                return "--,--";
            }
            return mediaFinal.ToString("F");
        }
        private void ReceberMediaArtes()
        {
            try
            {
                double media1 = mediaModel.ReceberMedia(aluno, 1, 1);
                double media2 = mediaModel.ReceberMedia(aluno, 2, 1);
                double media3 = mediaModel.ReceberMedia(aluno, 3, 1);
                double media4 = mediaModel.ReceberMedia(aluno, 4, 1);

                lbl1Artes.Text = MostrarNotaOuNula(media1);
                lbl2Artes.Text = MostrarNotaOuNula(media2);
                lbl3Artes.Text = MostrarNotaOuNula(media3);
                lbl4Artes.Text = MostrarNotaOuNula(media4);

                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMArtes.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSArtes.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
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

                lbl1EF.Text = MostrarNotaOuNula(media1);
                lbl2EF.Text = MostrarNotaOuNula(media2);
                lbl3EF.Text = MostrarNotaOuNula(media3);
                lbl4EF.Text = MostrarNotaOuNula(media4);

                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMEF.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSEF.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
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

                lbl1Filosifia.Text = MostrarNotaOuNula(media1);
                lbl2Filosifia.Text = MostrarNotaOuNula(media2);
                lbl3Filosifia.Text = MostrarNotaOuNula(media3);
                lbl4Filosifia.Text = MostrarNotaOuNula(media4);

                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMFilosifia.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSFilosifia.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
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

                lbl1Sociologia.Text = MostrarNotaOuNula(media1);
                lbl2Sociologia.Text = MostrarNotaOuNula(media2);
                lbl3Sociologia.Text = MostrarNotaOuNula(media3);
                lbl4Sociologia.Text = MostrarNotaOuNula(media4);

                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMSociologia.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSSociologia.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
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
                lbl1Ingles.Text = MostrarNotaOuNula(media1);
                lbl2Ingles.Text = MostrarNotaOuNula(media2);
                lbl3Ingles.Text = MostrarNotaOuNula(media3);
                lbl4Ingles.Text = MostrarNotaOuNula(media4);
                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMIngles.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSIngles.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
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
                lbl1Fisica.Text = MostrarNotaOuNula(media1);
                lbl2Fisica.Text = MostrarNotaOuNula(media2);
                lbl3Fisica.Text = MostrarNotaOuNula(media3);
                lbl4Fisica.Text = MostrarNotaOuNula(media4);
                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMFisica.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSFisica.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
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
                lbl1Quimica.Text = MostrarNotaOuNula(media1);
                lbl2Quimica.Text = MostrarNotaOuNula(media2);
                lbl3Quimica.Text = MostrarNotaOuNula(media3);
                lbl4Quimica.Text = MostrarNotaOuNula(media4);
                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMQuimica.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSQuimica.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
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
                lbl1Biologia.Text = MostrarNotaOuNula(media1);
                lbl2Biologia.Text = MostrarNotaOuNula(media2);
                lbl3Biologia.Text = MostrarNotaOuNula(media3);
                lbl4Biologia.Text = MostrarNotaOuNula(media4);
                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMBiologia.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSBiologia.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
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
                lbl1Geografia.Text = MostrarNotaOuNula(media1);
                lbl2Geografia.Text = MostrarNotaOuNula(media2);
                lbl3Geografia.Text = MostrarNotaOuNula(media3);
                lbl4Geografia.Text = MostrarNotaOuNula(media4);
                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMGeografia.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSGeografia.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
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
                lbl1Historia.Text = MostrarNotaOuNula(media1);
                lbl2Historia.Text = MostrarNotaOuNula(media2);
                lbl3Historia.Text = MostrarNotaOuNula(media3);
                lbl4Historia.Text = MostrarNotaOuNula(media4);
                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMHistoria.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSHistoria.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
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
                lbl1Matematica.Text = MostrarNotaOuNula(media1);
                lbl2Matematica.Text = MostrarNotaOuNula(media2);
                lbl3Matematica.Text = MostrarNotaOuNula(media3);
                lbl4Matematica.Text = MostrarNotaOuNula(media4);
                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMMatematica.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSMatematica.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);

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
                lbl1LP.Text = MostrarNotaOuNula(media1);
                lbl2LP.Text = MostrarNotaOuNula(media2);
                lbl3LP.Text = MostrarNotaOuNula(media3);
                lbl4LP.Text = MostrarNotaOuNula(media4);
                double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
                lblMLP.Text = MostrarMediaFinal(mediaFinal, media1, media2, media3, media4);
                lblSLP.Text = AprovadoOuReporovado(mediaFinal, media1, media2, media3, media4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
       
        private string AprovadoOuReporovado(double nota, double media1, double media2, double media3, double media4)
        {
            if(media1 == -1 || media2 == -1 || media3 == -1 || media4 == -1)
            {
                return "";
            }
            if (nota > media.NotaMinima)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";
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
