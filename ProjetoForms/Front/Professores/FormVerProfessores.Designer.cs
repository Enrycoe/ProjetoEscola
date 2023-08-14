namespace ProjetoForms.Front.Professores
{
    partial class FormVerProfessores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gridProfessores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Pessoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Fixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_de_Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_endereço_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.gridProfessores);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 632);
            this.panel1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTitulo.Location = new System.Drawing.Point(2, 424);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 208);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "PROFESSORES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(60, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(145, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do Professor";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(48, 118);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 26);
            this.txtNome.TabIndex = 1;
            // 
            // gridProfessores
            // 
            this.gridProfessores.AllowUserToAddRows = false;
            this.gridProfessores.AllowUserToDeleteRows = false;
            this.gridProfessores.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridProfessores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Idade,
            this.Telefone_Pessoal,
            this.Telefone_Fixo,
            this.Data_de_Nascimento,
            this.fk_endereço_id});
            this.gridProfessores.Location = new System.Drawing.Point(278, 0);
            this.gridProfessores.Name = "gridProfessores";
            this.gridProfessores.ReadOnly = true;
            this.gridProfessores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProfessores.Size = new System.Drawing.Size(759, 629);
            this.gridProfessores.TabIndex = 0;
            this.gridProfessores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfessores_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Idade.DataPropertyName = "Idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // Telefone_Pessoal
            // 
            this.Telefone_Pessoal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefone_Pessoal.DataPropertyName = "Telefone_Pessoal";
            this.Telefone_Pessoal.HeaderText = "Telefone Pessoal";
            this.Telefone_Pessoal.Name = "Telefone_Pessoal";
            this.Telefone_Pessoal.ReadOnly = true;
            // 
            // Telefone_Fixo
            // 
            this.Telefone_Fixo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefone_Fixo.DataPropertyName = "Telefone_Fixo";
            this.Telefone_Fixo.HeaderText = "Telefone Fixo";
            this.Telefone_Fixo.Name = "Telefone_Fixo";
            this.Telefone_Fixo.ReadOnly = true;
            // 
            // Data_de_Nascimento
            // 
            this.Data_de_Nascimento.DataPropertyName = "Data_de_Nascimento";
            this.Data_de_Nascimento.HeaderText = "Data de Nascimento";
            this.Data_de_Nascimento.Name = "Data_de_Nascimento";
            this.Data_de_Nascimento.ReadOnly = true;
            this.Data_de_Nascimento.Visible = false;
            // 
            // fk_endereço_id
            // 
            this.fk_endereço_id.DataPropertyName = "fk_endereço_id";
            this.fk_endereço_id.HeaderText = "Endereço";
            this.fk_endereço_id.Name = "fk_endereço_id";
            this.fk_endereço_id.ReadOnly = true;
            this.fk_endereço_id.Visible = false;
            // 
            // FormVerProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 635);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVerProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Professores";
            this.Load += new System.EventHandler(this.FormVerProfessores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView gridProfessores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Pessoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Fixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_de_Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_endereço_id;
    }
}