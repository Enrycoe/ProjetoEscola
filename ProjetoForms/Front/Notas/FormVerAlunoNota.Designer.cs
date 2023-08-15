namespace ProjetoForms
{
    partial class FormVerAlunoNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerAlunoNota));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitulo);
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
            this.panel1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 208);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "PROVA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.ForeColor = System.Drawing.Color.White;
            this.lblTurma.Location = new System.Drawing.Point(104, 455);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(54, 20);
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
            this.cbTurma.Location = new System.Drawing.Point(74, 478);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(121, 28);
            this.cbTurma.TabIndex = 5;
            this.cbTurma.TextChanged += new System.EventHandler(this.cbTurma_TextChanged);
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.BackColor = System.Drawing.Color.Transparent;
            this.lblRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRA.ForeColor = System.Drawing.Color.White;
            this.lblRA.Location = new System.Drawing.Point(93, 356);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(99, 20);
            this.lblRA.TabIndex = 4;
            this.lblRA.Text = "RA do Aluno";
            // 
            // txtRA
            // 
            this.txtRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRA.Location = new System.Drawing.Point(55, 379);
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
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(84, 239);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(118, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do Aluno";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(56, 262);
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
            this.gridAlunos.Location = new System.Drawing.Point(278, 0);
            this.gridAlunos.Name = "gridAlunos";
            this.gridAlunos.ReadOnly = true;
            this.gridAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlunos.Size = new System.Drawing.Size(759, 629);
            this.gridAlunos.TabIndex = 0;
            this.gridAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlunos_CellContentDoubleClick);
            // 
            // RA
            // 
            this.RA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RA.DataPropertyName = "RA";
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
            this.Turma_Nome.DataPropertyName = "Nome_Turma";
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 115);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormVerAlunoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 638);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVerAlunoNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Alunos";
            this.Load += new System.EventHandler(this.FormVerAlunoNota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}