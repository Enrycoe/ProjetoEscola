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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalcularMedia));
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.dataGridProvas = new System.Windows.Forms.DataGridView();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbBimestre = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvarMedia = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvas)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.ForeColor = System.Drawing.Color.White;
            this.lblMateria.Location = new System.Drawing.Point(13, 79);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(62, 18);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia:";
            // 
            // dataGridProvas
            // 
            this.dataGridProvas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProvas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProvas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProvas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.nota,
            this.descricao,
            this.ID});
            this.dataGridProvas.Location = new System.Drawing.Point(12, 157);
            this.dataGridProvas.Name = "dataGridProvas";
            this.dataGridProvas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProvas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.dataGridProvas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridProvas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProvas.Size = new System.Drawing.Size(444, 270);
            this.dataGridProvas.TabIndex = 2;
            this.dataGridProvas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProvas_CellContentClick);
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(339, 31);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 26);
            this.txtMedia.TabIndex = 6;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.BackColor = System.Drawing.Color.Transparent;
            this.lblMedia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.Color.White;
            this.lblMedia.Location = new System.Drawing.Point(277, 33);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(52, 18);
            this.lblMedia.TabIndex = 7;
            this.lblMedia.Text = "Media:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(13, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 18);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "label1";
            // 
            // cbBimestre
            // 
            this.cbBimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBimestre.FormattingEnabled = true;
            this.cbBimestre.Location = new System.Drawing.Point(277, 79);
            this.cbBimestre.Name = "cbBimestre";
            this.cbBimestre.Size = new System.Drawing.Size(162, 28);
            this.cbBimestre.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnSalvarMedia);
            this.panel1.Location = new System.Drawing.Point(462, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 175);
            this.panel1.TabIndex = 27;
            // 
            // btnSalvarMedia
            // 
            this.btnSalvarMedia.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarMedia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvarMedia.BackgroundImage")));
            this.btnSalvarMedia.FlatAppearance.BorderSize = 0;
            this.btnSalvarMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarMedia.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMedia.ForeColor = System.Drawing.Color.Green;
            this.btnSalvarMedia.Location = new System.Drawing.Point(73, 59);
            this.btnSalvarMedia.Name = "btnSalvarMedia";
            this.btnSalvarMedia.Size = new System.Drawing.Size(60, 60);
            this.btnSalvarMedia.TabIndex = 5;
            this.btnSalvarMedia.UseVisualStyleBackColor = false;
            this.btnSalvarMedia.Click += new System.EventHandler(this.btnSalvarMedia_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(601, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.ReadOnly = true;
            this.CheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckBox.Width = 5;
            // 
            // nota
            // 
            this.nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nota.DataPropertyName = "Nota";
            this.nota.HeaderText = "Nota";
            this.nota.MinimumWidth = 80;
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            this.nota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nota.Width = 80;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 315;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descricao.Width = 315;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FormCalcularMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(663, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbBimestre);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.dataGridProvas);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cbMateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalcularMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média";
            this.Load += new System.EventHandler(this.FormCalcularMedia_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCalcularMedia_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.DataGridView dataGridProvas;
        private System.Windows.Forms.Button btnSalvarMedia;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbBimestre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}