﻿namespace ProjetoForms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotaTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalcularMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professoresToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.NotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProfessoresToolStripMenuItem,
            this.cadastrarProfessoresToolStripMenuItem});
            this.professoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("professoresToolStripMenuItem.Image")));
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.professoresToolStripMenuItem.Text = "Professores";
            // 
            // verProfessoresToolStripMenuItem
            // 
            this.verProfessoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verProfessoresToolStripMenuItem.Image")));
            this.verProfessoresToolStripMenuItem.Name = "verProfessoresToolStripMenuItem";
            this.verProfessoresToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.verProfessoresToolStripMenuItem.Text = "Ver Professores";
            this.verProfessoresToolStripMenuItem.Click += new System.EventHandler(this.verProfessoresToolStripMenuItem_Click);
            // 
            // cadastrarProfessoresToolStripMenuItem
            // 
            this.cadastrarProfessoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarProfessoresToolStripMenuItem.Image")));
            this.cadastrarProfessoresToolStripMenuItem.Name = "cadastrarProfessoresToolStripMenuItem";
            this.cadastrarProfessoresToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cadastrarProfessoresToolStripMenuItem.Text = "Cadastrar Professor";
            this.cadastrarProfessoresToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProfessoresToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAlunosToolStripMenuItem,
            this.cadastrarAlunosToolStripMenuItem});
            this.alunosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunosToolStripMenuItem.Image")));
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // verAlunosToolStripMenuItem
            // 
            this.verAlunosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verAlunosToolStripMenuItem.Image")));
            this.verAlunosToolStripMenuItem.Name = "verAlunosToolStripMenuItem";
            this.verAlunosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.verAlunosToolStripMenuItem.Text = "Ver Alunos";
            this.verAlunosToolStripMenuItem.Click += new System.EventHandler(this.verAlunosToolStripMenuItem_Click);
            // 
            // cadastrarAlunosToolStripMenuItem
            // 
            this.cadastrarAlunosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarAlunosToolStripMenuItem.Image")));
            this.cadastrarAlunosToolStripMenuItem.Name = "cadastrarAlunosToolStripMenuItem";
            this.cadastrarAlunosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cadastrarAlunosToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunosToolStripMenuItem_Click);
            // 
            // NotasToolStripMenuItem
            // 
            this.NotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotaTurmasToolStripMenuItem,
            this.CalcularMediaToolStripMenuItem,
            this.boletimToolStripMenuItem1});
            this.NotasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NotasToolStripMenuItem.Image")));
            this.NotasToolStripMenuItem.Name = "NotasToolStripMenuItem";
            this.NotasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.NotasToolStripMenuItem.Text = "Notas";
            // 
            // NotaTurmasToolStripMenuItem
            // 
            this.NotaTurmasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NotaTurmasToolStripMenuItem.Image")));
            this.NotaTurmasToolStripMenuItem.Name = "NotaTurmasToolStripMenuItem";
            this.NotaTurmasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.NotaTurmasToolStripMenuItem.Text = "Aplicar Nota à Provas";
            this.NotaTurmasToolStripMenuItem.Click += new System.EventHandler(this.NotaTurmasToolStripMenuItem_Click);
            // 
            // CalcularMediaToolStripMenuItem
            // 
            this.CalcularMediaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CalcularMediaToolStripMenuItem.Image")));
            this.CalcularMediaToolStripMenuItem.Name = "CalcularMediaToolStripMenuItem";
            this.CalcularMediaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.CalcularMediaToolStripMenuItem.Text = "Calcular Media";
            this.CalcularMediaToolStripMenuItem.Click += new System.EventHandler(this.CalcularMediaToolStripMenuItem_Click);
            // 
            // boletimToolStripMenuItem1
            // 
            this.boletimToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("boletimToolStripMenuItem1.Image")));
            this.boletimToolStripMenuItem1.Name = "boletimToolStripMenuItem1";
            this.boletimToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.boletimToolStripMenuItem1.Text = "Boletim";
            this.boletimToolStripMenuItem1.Click += new System.EventHandler(this.boletimToolStripMenuItem1_Click);
            // 
            // lblDataHora
            // 
            this.lblDataHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataHora.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDataHora.Font = new System.Drawing.Font("Agency FB", 63.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.lblDataHora.Location = new System.Drawing.Point(378, 292);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(676, 112);
            this.lblDataHora.TabIndex = 0;
            this.lblDataHora.Text = "dd/MM/yyyy HH:mm:ss    ";
            this.lblDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1288, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogoff.BackgroundImage")));
            this.btnLogoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoff.FlatAppearance.BorderSize = 0;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Location = new System.Drawing.Point(1232, 12);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(50, 50);
            this.btnLogoff.TabIndex = 3;
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeProfessor.AutoSize = true;
            this.lblNomeProfessor.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.lblNomeProfessor.Location = new System.Drawing.Point(12, 691);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNomeProfessor.Size = new System.Drawing.Size(80, 29);
            this.lblNomeProfessor.TabIndex = 4;
            this.lblNomeProfessor.Text = "Nome";
            this.lblNomeProfessor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::ProjetoForms.Properties.Resources.FundoXD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblNomeProfessor);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XD People";
            this.Load += new System.EventHandler(this.lblDataHora_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotaTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalcularMediaToolStripMenuItem;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.ToolStripMenuItem boletimToolStripMenuItem1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Label lblNomeProfessor;
    }
}

