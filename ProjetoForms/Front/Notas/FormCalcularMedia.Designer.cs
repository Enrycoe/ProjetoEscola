namespace ProjetoForms.Front.Notas
{
    partial class FormCalcularMedia
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
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.dataGridProvas = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_Materia_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_Aluno_RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_media_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvarMedia = new System.Windows.Forms.Button();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbBimestre = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMateria
            // 
            this.cbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(85, 78);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(121, 28);
            this.cbMateria.TabIndex = 0;
            this.cbMateria.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(13, 79);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(66, 20);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia:";
            // 
            // dataGridProvas
            // 
            this.dataGridProvas.AllowUserToAddRows = false;
            this.dataGridProvas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProvas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.nota,
            this.ID,
            this.descricao,
            this.fk_Materia_ID,
            this.fk_Aluno_RA,
            this.fk_media_ID});
            this.dataGridProvas.Location = new System.Drawing.Point(124, 157);
            this.dataGridProvas.Name = "dataGridProvas";
            this.dataGridProvas.ReadOnly = true;
            this.dataGridProvas.Size = new System.Drawing.Size(444, 270);
            this.dataGridProvas.TabIndex = 2;
            this.dataGridProvas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProvas_CellContentClick);
            // 
            // CheckBox
            // 
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.ReadOnly = true;
            this.CheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "nota";
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            this.nota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fk_Materia_ID
            // 
            this.fk_Materia_ID.DataPropertyName = "fk_Materia_ID";
            this.fk_Materia_ID.HeaderText = "Materia_ID";
            this.fk_Materia_ID.Name = "fk_Materia_ID";
            this.fk_Materia_ID.ReadOnly = true;
            this.fk_Materia_ID.Visible = false;
            // 
            // fk_Aluno_RA
            // 
            this.fk_Aluno_RA.DataPropertyName = "fk_Aluno_RA";
            this.fk_Aluno_RA.HeaderText = "Aluno_RA";
            this.fk_Aluno_RA.Name = "fk_Aluno_RA";
            this.fk_Aluno_RA.ReadOnly = true;
            this.fk_Aluno_RA.Visible = false;
            // 
            // fk_media_ID
            // 
            this.fk_media_ID.DataPropertyName = "fk_media_ID";
            this.fk_media_ID.HeaderText = "Media";
            this.fk_media_ID.Name = "fk_media_ID";
            this.fk_media_ID.ReadOnly = true;
            this.fk_media_ID.Visible = false;
            // 
            // btnSalvarMedia
            // 
            this.btnSalvarMedia.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMedia.ForeColor = System.Drawing.Color.Green;
            this.btnSalvarMedia.Location = new System.Drawing.Point(532, 12);
            this.btnSalvarMedia.Name = "btnSalvarMedia";
            this.btnSalvarMedia.Size = new System.Drawing.Size(149, 64);
            this.btnSalvarMedia.TabIndex = 5;
            this.btnSalvarMedia.Text = "Salvar";
            this.btnSalvarMedia.UseVisualStyleBackColor = true;
            this.btnSalvarMedia.Click += new System.EventHandler(this.btnSalvarMedia_Click);
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(415, 32);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 26);
            this.txtMedia.TabIndex = 6;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(353, 34);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(56, 20);
            this.lblMedia.TabIndex = 7;
            this.lblMedia.Text = "Media:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(13, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "label1";
            // 
            // cbBimestre
            // 
            this.cbBimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBimestre.FormattingEnabled = true;
            this.cbBimestre.Location = new System.Drawing.Point(353, 79);
            this.cbBimestre.Name = "cbBimestre";
            this.cbBimestre.Size = new System.Drawing.Size(162, 28);
            this.cbBimestre.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(12, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 60);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCalcularMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 504);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbBimestre);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.btnSalvarMedia);
            this.Controls.Add(this.dataGridProvas);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cbMateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalcularMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média";
            this.Load += new System.EventHandler(this.FormCalcularMedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.DataGridView dataGridProvas;
        private System.Windows.Forms.Button btnSalvarMedia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_Materia_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_Aluno_RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_media_ID;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbBimestre;
        private System.Windows.Forms.Button btnCancelar;
    }
}