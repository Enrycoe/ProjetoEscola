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
    public partial class FormBoletim : Form
    {
        Aluno aluno;
        AlunoModel alunoModel = new AlunoModel();
        MediaModel mediaModel = new MediaModel();
        Media media = new Media();
        int x = 0;
        int y = 0;
        public FormBoletim(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = alunoModel.ReceberAluno(aluno.Id);
        }

        private void lblNome_Load(object sender, EventArgs e)
        {

            lblNome.Text = aluno.Nome;
            lblRA.Text = aluno.Id.ToString();
            lblTurma.Text = aluno.Turma.Nome.ToString();
            ReceberMedia();
        }
        private void ReceberMedia()
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
        private void ReceberMediaArtes()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 1);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 1);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 1);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 1);
            lbl1Artes.Text = media1.ToString("F");
            lbl2Artes.Text = media2.ToString("F");
            lbl3Artes.Text = media3.ToString("F");
            lbl4Artes.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMArtes.Text = mediaFinal.ToString("F");
            lblSArtes.Text = AprovadoOuReporovado(mediaFinal);
        }
        private void ReceberMediaEducacaoFisica()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 2);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 2);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 2);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 2);
            lbl1EF.Text = media1.ToString("F");
            lbl2EF.Text = media2.ToString("F");
            lbl3EF.Text = media3.ToString("F");
            lbl4EF.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMEF.Text = mediaFinal.ToString("F");
            lblSEF.Text = AprovadoOuReporovado(mediaFinal);
        }

        private void ReceberMediaFilosifia()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 3);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 3);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 3);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 3);
            lbl1Filosifia.Text = media1.ToString("F");
            lbl2Filosifia.Text = media2.ToString("F");
            lbl3Filosifia.Text = media3.ToString("F");
            lbl4Filosifia.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMFilosifia.Text = mediaFinal.ToString("F");
           lblSFilosifia.Text = AprovadoOuReporovado(mediaFinal);
        }

        private void ReceberMediaSociologia()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 4);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 4);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 4);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 4);
            lbl1Sociologia.Text = media1.ToString("F");
            lbl2Sociologia.Text = media2.ToString("F");
            lbl3Sociologia.Text = media3.ToString("F");
            lbl4Sociologia.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMSociologia.Text = mediaFinal.ToString("F");
            lblSSociologia.Text = AprovadoOuReporovado(mediaFinal);
        }

        private void ReceberMediaIngles()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 5);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 5);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 5);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 5);
            lbl1Ingles.Text = media1.ToString("F");
            lbl2Ingles.Text = media2.ToString("F");
            lbl3Ingles.Text = media3.ToString("F");
            lbl4Ingles.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMIngles.Text = mediaFinal.ToString("F");
            lblSIngles.Text = AprovadoOuReporovado(mediaFinal);
        }

        private void ReceberMediaFisica()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 6);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 6);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 6);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 6);
            lbl1Fisica.Text = media1.ToString("F"); 
            lbl2Fisica.Text = media2.ToString("F");
            lbl3Fisica.Text = media3.ToString("F");
            lbl4Fisica.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMFisica.Text = mediaFinal.ToString("F");
            lblSFisica.Text = AprovadoOuReporovado(mediaFinal);
        }

        private void ReceberMediaQuimica()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 7);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 7);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 7);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 7);
            lbl1Quimica.Text = media1.ToString("F");
            lbl2Quimica.Text = media2.ToString("F");
            lbl3Quimica.Text = media3.ToString("F");        
            lbl4Quimica.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMQuimica.Text = mediaFinal.ToString("F");
            lblSQuimica.Text = AprovadoOuReporovado(mediaFinal);
        }

        private void ReceberMediaBiologia()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 8);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 8);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 8);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 8);
            lbl1Biologia.Text = media1.ToString("F");
            lbl2Biologia.Text = media2.ToString("F");
            lbl3Biologia.Text = media3.ToString("F");
            lbl4Biologia.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMBiologia.Text = mediaFinal.ToString("F");
            lblSBiologia.Text = AprovadoOuReporovado(mediaFinal);
        }

        private void ReceberMediaGeografia()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 9);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 9);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 9);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 9);
            lbl1Geografia.Text = media1.ToString("F"); 
            lbl2Geografia.Text = media2.ToString("F");
            lbl3Geografia.Text = media3.ToString("F");
            lbl4Geografia.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMGeografia.Text = mediaFinal.ToString("F");
            lblSGeografia.Text = AprovadoOuReporovado(mediaFinal);
        }

        private void ReceberMediaHistoria()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 10);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 10);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 10);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 10);
            lbl1Historia.Text = media1.ToString("F");
            lbl2Historia.Text = media2.ToString("F");
            lbl3Historia.Text = media3.ToString("F");
            lbl4Historia.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMHistoria.Text = mediaFinal.ToString("F");
            lblSHistoria.Text = AprovadoOuReporovado(mediaFinal);
        }

        private void ReceberMediaMatematica()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 11);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 11);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 11);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 11);
            lbl1Matematica.Text = media1.ToString("F");
            lbl2Matematica.Text = media2.ToString("F");
            lbl3Matematica.Text = media3.ToString("F");  
            lbl4Matematica.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMMatematica.Text = mediaFinal.ToString("F");
            lblSMatematica.Text = AprovadoOuReporovado(mediaFinal);
        }

        private void ReceberMediaPortugues()
        {
            double media1 = mediaModel.ReceberMedia(aluno, 1, 12);
            double media2 = mediaModel.ReceberMedia(aluno, 2, 12);
            double media3 = mediaModel.ReceberMedia(aluno, 3, 12);
            double media4 = mediaModel.ReceberMedia(aluno, 4, 12);
            lbl1LP.Text = media1.ToString("F");
            lbl2LP.Text = media2.ToString("F");
            lbl3LP.Text = media3.ToString("F");
            lbl4LP.Text = media4.ToString("F");
            double mediaFinal = ((media1 + media2 + media3 + media4) / 4);
            lblMLP.Text = mediaFinal.ToString("F");
            lblSLP.Text = AprovadoOuReporovado(mediaFinal);
        }
       
        private string AprovadoOuReporovado(double nota)
        {
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
    }
}
