﻿namespace ProjetoForms
{
    partial class FormVerAlunoBoletim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerAlunoBoletim));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.cbTurma = new System.Windows.Forms.ComboBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gridAlunos = new System.Windows.Forms.DataGridView();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turma_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_Turma_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Pessoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_FIxo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Responsavel_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_de_Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_endereco_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.cbTurma);
            this.panel1.Controls.Add(this.lblRA);
            this.panel1.Controls.Add(this.txtRA);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.gridAlunos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 632);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.Location = new System.Drawing.Point(973, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(50, 50);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 115);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblTurma.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.ForeColor = System.Drawing.Color.White;
            this.lblTurma.Location = new System.Drawing.Point(851, 88);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(51, 18);
            this.lblTurma.TabIndex = 6;
            this.lblTurma.Text = "Turma";
            // 
            // cbTurma
            // 
            this.cbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Items.AddRange(new object[] {
            " "});
            this.cbTurma.Location = new System.Drawing.Point(820, 121);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(121, 28);
            this.cbTurma.TabIndex = 5;
            this.cbTurma.TextChanged += new System.EventHandler(this.cbTurma_TextChanged);
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.BackColor = System.Drawing.Color.Transparent;
            this.lblRA.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRA.ForeColor = System.Drawing.Color.White;
            this.lblRA.Location = new System.Drawing.Point(648, 88);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(95, 18);
            this.lblRA.TabIndex = 4;
            this.lblRA.Text = "RA do Aluno";
            // 
            // txtRA
            // 
            this.txtRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRA.Location = new System.Drawing.Point(611, 123);
            this.txtRA.MaxLength = 8;
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(174, 26);
            this.txtRA.TabIndex = 3;
            this.txtRA.TextChanged += new System.EventHandler(this.txtRA_TextChanged);
            this.txtRA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRA_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(430, 88);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(109, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do Aluno";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(402, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // gridAlunos
            // 
            this.gridAlunos.AllowUserToAddRows = false;
            this.gridAlunos.AllowUserToDeleteRows = false;
            this.gridAlunos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridAlunos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RA,
            this.Nome,
            this.Idade,
            this.Turma_Nome,
            this.fk_Turma_ID,
            this.Telefone_Pessoal,
            this.Telefone_FIxo,
            this.Telefone_Responsavel,
            this.Telefone_Responsavel_2,
            this.data_de_Nascimento,
            this.fk_endereco_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAlunos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAlunos.Location = new System.Drawing.Point(64, 216);
            this.gridAlunos.MultiSelect = false;
            this.gridAlunos.Name = "gridAlunos";
            this.gridAlunos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.gridAlunos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlunos.Size = new System.Drawing.Size(909, 361);
            this.gridAlunos.TabIndex = 0;
            this.gridAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlunos_CellContentDoubleClick);
            // 
            // RA
            // 
            this.RA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RA.DataPropertyName = "Id";
            this.RA.HeaderText = "RA";
            this.RA.Name = "RA";
            this.RA.ReadOnly = true;
            this.RA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RA.Width = 47;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Idade
            // 
            this.Idade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Idade.DataPropertyName = "Idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            this.Idade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Turma_Nome
            // 
            this.Turma_Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Turma_Nome.DataPropertyName = "Turma";
            this.Turma_Nome.HeaderText = "Turma";
            this.Turma_Nome.Name = "Turma_Nome";
            this.Turma_Nome.ReadOnly = true;
            this.Turma_Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Turma_Nome.Width = 62;
            // 
            // fk_Turma_ID
            // 
            this.fk_Turma_ID.DataPropertyName = "fk_Turma_ID";
            this.fk_Turma_ID.HeaderText = "fk_Turma";
            this.fk_Turma_ID.Name = "fk_Turma_ID";
            this.fk_Turma_ID.ReadOnly = true;
            this.fk_Turma_ID.Visible = false;
            // 
            // Telefone_Pessoal
            // 
            this.Telefone_Pessoal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Telefone_Pessoal.DataPropertyName = "Telefone_Pessoal";
            this.Telefone_Pessoal.HeaderText = "Telefone Pessoal";
            this.Telefone_Pessoal.Name = "Telefone_Pessoal";
            this.Telefone_Pessoal.ReadOnly = true;
            this.Telefone_Pessoal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Telefone_Pessoal.Visible = false;
            // 
            // Telefone_FIxo
            // 
            this.Telefone_FIxo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Telefone_FIxo.DataPropertyName = "Telefone_Fixo";
            this.Telefone_FIxo.HeaderText = "Telefone Fixo";
            this.Telefone_FIxo.Name = "Telefone_FIxo";
            this.Telefone_FIxo.ReadOnly = true;
            this.Telefone_FIxo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Telefone_FIxo.Visible = false;
            // 
            // Telefone_Responsavel
            // 
            this.Telefone_Responsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Telefone_Responsavel.DataPropertyName = "Telefone_Responsavel";
            this.Telefone_Responsavel.HeaderText = "Telefone Responsavel";
            this.Telefone_Responsavel.Name = "Telefone_Responsavel";
            this.Telefone_Responsavel.ReadOnly = true;
            this.Telefone_Responsavel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Telefone_Responsavel.Visible = false;
            // 
            // Telefone_Responsavel_2
            // 
            this.Telefone_Responsavel_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Telefone_Responsavel_2.DataPropertyName = "Telefone_Responsavel_2";
            this.Telefone_Responsavel_2.HeaderText = "Telefone Responsavel";
            this.Telefone_Responsavel_2.Name = "Telefone_Responsavel_2";
            this.Telefone_Responsavel_2.ReadOnly = true;
            this.Telefone_Responsavel_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Telefone_Responsavel_2.Visible = false;
            // 
            // data_de_Nascimento
            // 
            this.data_de_Nascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.data_de_Nascimento.DataPropertyName = "Data_de_Nascimento";
            this.data_de_Nascimento.HeaderText = "Data de Nascimento";
            this.data_de_Nascimento.Name = "data_de_Nascimento";
            this.data_de_Nascimento.ReadOnly = true;
            this.data_de_Nascimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.data_de_Nascimento.Visible = false;
            // 
            // fk_endereco_id
            // 
            this.fk_endereco_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fk_endereco_id.DataPropertyName = "fk_endereco_id";
            this.fk_endereco_id.HeaderText = "Endereço";
            this.fk_endereco_id.Name = "fk_endereco_id";
            this.fk_endereco_id.ReadOnly = true;
            this.fk_endereco_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fk_endereco_id.Visible = false;
            // 
            // FormVerAlunoBoletim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 631);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVerAlunoBoletim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Alunos";
            this.Load += new System.EventHandler(this.FormVerAlunoBoletim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cbTurma;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView gridAlunos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turma_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_Turma_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Pessoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_FIxo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Responsavel_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_de_Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_endereco_id;
    }
}