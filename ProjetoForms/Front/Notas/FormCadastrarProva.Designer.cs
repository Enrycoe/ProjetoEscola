namespace ProjetoForms.Front.Notas
{
    partial class FormCadastrarProva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarProva));
            this.lblAluno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrarProva = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAluno
            // 
            this.lblAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.ForeColor = System.Drawing.Color.White;
            this.lblAluno.Location = new System.Drawing.Point(17, 25);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(46, 18);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.cbMateria);
            this.panel1.Controls.Add(this.txtNota);
            this.panel1.Controls.Add(this.lblMateria);
            this.panel1.Controls.Add(this.lblNota);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Location = new System.Drawing.Point(-9, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 155);
            this.panel1.TabIndex = 26;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(111, 92);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(230, 26);
            this.txtDesc.TabIndex = 3;
            // 
            // cbMateria
            // 
            this.cbMateria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(111, 26);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(121, 28);
            this.cbMateria.TabIndex = 1;
            // 
            // txtNota
            // 
            this.txtNota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(111, 64);
            this.txtNota.MaxLength = 5;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(60, 22);
            this.txtNota.TabIndex = 8;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // lblMateria
            // 
            this.lblMateria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(30, 34);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(58, 18);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Matéria";
            // 
            // lblNota
            // 
            this.lblNota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNota.AutoSize = true;
            this.lblNota.BackColor = System.Drawing.Color.Transparent;
            this.lblNota.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(30, 66);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(38, 18);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "Nota";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(30, 98);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 18);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(298, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrarProva
            // 
            this.btnCadastrarProva.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarProva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarProva.BackgroundImage")));
            this.btnCadastrarProva.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProva.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProva.ForeColor = System.Drawing.Color.Green;
            this.btnCadastrarProva.Location = new System.Drawing.Point(272, 231);
            this.btnCadastrarProva.Name = "btnCadastrarProva";
            this.btnCadastrarProva.Size = new System.Drawing.Size(60, 60);
            this.btnCadastrarProva.TabIndex = 7;
            this.btnCadastrarProva.UseVisualStyleBackColor = false;
            this.btnCadastrarProva.Click += new System.EventHandler(this.btnCadastrarProva_Click);
            // 
            // FormCadastrarProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(360, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarProva);
            this.Controls.Add(this.lblAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastrarProva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prova";
            this.Load += new System.EventHandler(this.FormCadastrarProva_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCadastrarProva_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCadastrarProva;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
    }
}